using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DiskSchedulingGraph
{
    public partial class Form1 : Form
    {

        string schedule;

        public Form1()
        {
            InitializeComponent();
        }



        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (!( emptyField(txt_track1) && emptyField(txt_track2) &&
                 emptyField(txt_track3) && emptyField(txt_track4) &&
                 emptyField(txt_track5) && emptyField(txt_track6) &&
                 emptyField(txt_track7) && emptyField(txt_track8) && emptyField(txt_headmovement)))
            {

                int t1 = int.Parse(txt_track1.Text);
                int t2 = int.Parse(txt_track2.Text);
                int t3 = int.Parse(txt_track3.Text);
                int t4 = int.Parse(txt_track4.Text);
                int t5 = int.Parse(txt_track5.Text);
                int t6 = int.Parse(txt_track6.Text);
                int t7 = int.Parse(txt_track7.Text);
                int t8 = int.Parse(txt_track8.Text);
                int headMovement = int.Parse(txt_headmovement.Text);
                string diskSchedule = cb_diskSchedule.SelectedItem.ToString();
                this.schedule= diskSchedule;
                int[] tracks = new int[20];
                tracks[0] = t1; tracks[1] = t2; tracks[2] = t3; tracks[3] = t4; tracks[4] = t5; tracks[5] = t6; tracks[6] = t7; tracks[7] = t8;

                if (diskSchedule.ToUpper().Trim().Equals("FCFS"))
                {
                    fcfs(tracks, headMovement, 8);
                }
                else if (diskSchedule.ToUpper().Trim().Equals("SSTF"))
                {
                    sstf(tracks, headMovement, 8);
                }
                else if (diskSchedule.ToUpper().Trim().Equals("SCAN"))
                {
                    scan(tracks, headMovement, 8);
                }
                else if (diskSchedule.ToUpper().Trim().Equals("C-SCAN"))
                {
                    cscan(tracks, headMovement, 8);
                }
                else if (diskSchedule.ToUpper().Trim().Equals("LOOK"))
                {
                    look(tracks, headMovement, 8);
                }
                else if (diskSchedule.ToUpper().Trim().Equals("C-LOOK"))
                {
                    clook(tracks, headMovement, 8);
                }
                 
            } 
            else
                MessageBox.Show("Please Fill up all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void Txt_track5_TextChanged(object sender, EventArgs e)
        {

        }


        public void fcfs(int[] ar, int disk, int n)
        {
            Console.WriteLine("\nSHOW FIRST COME FIRST SERVE");
            int i, j, sum = 0;
            int[] tm = new int[20];
            Console.WriteLine("Enter elements of disk queue:");
            for (i = 0; i < n; i++)
            {

                tm[i] = disk - ar[i];
                if (tm[i] < 0)
                {
                    tm[i] = ar[i] - disk;
                }
                disk = ar[i];
                sum = sum + tm[i];

            }
            for (int k = 0; k < n; k++)
                Console.Write(tm[k] + "-");

            this.txt_totalHead.Text = sum.ToString();
            generateChart(ar, disk, n);
            Console.WriteLine("\nTotal Head Movements: " + sum);
            sum = 0;

        }

        public void sstf(int[] arr, int disk, int n)
        {
            Console.WriteLine("\nSHOW Shortest seek time first"); 
            shortestSeekTimeFirst(arr, disk, n);

        }

        public void scan(int[] d, int disk, int n)
        {
            Console.WriteLine("\nSHOW SCAN");
            int i, j, sum = 0;
            int temp, max;
            int dloc;   //loc of disk in array 
            int[] printArr = new int[20];
            d[n] = disk;
            n = n + 1;
            for (i = 0; i < n; i++)    // sorting disk locations
            {
                for (j = i; j < n; j++)
                {
                    if (d[i] > d[j])
                    {
                        temp = d[i];
                        d[i] = d[j];
                        d[j] = temp;
                    }
                }
            }
            max = d[n]; 
            dloc = 0;
            for (i = 0; i < n; i++)   // to find loc of disc in array
            {
                if (disk == d[i]) { dloc = i; break; }
            } 

            int ctr = 0;
            for (i = dloc; i >= 0; i--)
            {
                if (i != 0)
                    sum += (d[i] - d[i - 1]);
                else sum += d[i];
                printArr[ctr] = d[i];
                ctr++; 
            }
            printArr[ctr++] = 0; 
            for (i = dloc; i < n; i++)
            {
                if (i == (n - 1)) break;
                if (i == dloc)
                    sum += (d[i + 1] - 0);
                else
                {
                    if (d[i] > d[i - 1])
                        sum += (d[i + 1] - d[i]);
                    else
                        sum += (d[i] - d[i - 1]);
                } 
                if (i != n - 2 || i != dloc) Console.Write(" --> ");
                printArr[ctr] = d[i + 1];
                ctr++;
            } 
            Console.WriteLine("\nTotal Head Movements: " + sum);
            this.txt_totalHead.Text = sum.ToString();
            generateChart(printArr, disk, n+1);
        }

        public void cscan(int[] d, int disk, int n)
        {

            Console.WriteLine("\nSHOW C-SCAN");
            // Initialization 
             
            int i, j, sum = 0;
            int temp, min = 0, max=200;
            int dloc;   //loc of disk in array 
            int[] printArr = new int[20];
            d[n] = disk;
            n = n + 1;
            for (i = 0; i < n; i++)    // sorting disk locations
            {
                for (j = i; j < n; j++)
                {
                    if (d[i] > d[j])
                    {
                        temp = d[i];
                        d[i] = d[j];
                        d[j] = temp;
                    }
                }
            }
            d[n] = disk;
            n = n + 1;
            for (i = 0; i < n; i++)    // sorting disk locations
            {
                for (j = i; j < n; j++)
                {
                    if (d[i] > d[j])
                    {
                        temp = d[i];
                        d[i] = d[j];
                        d[j] = temp;
                    }
                }
            }
            dloc = 0;
            for (i = 0; i < n; i++)   // to find loc of disc in array
            {
                if (disk == d[i]) { dloc = i; break; }
            }
            Console.WriteLine("===");
            Console.WriteLine("Movements");
            int ctr = 0;
            for (i = dloc; i < n; i++)
            {

                if (i != (n - 1))
                {
                    sum += Math.Abs(d[i + 1] - d[i]);

                    Console.Write(d[i] + "-");
                }
                if (i == (n - 1))
                {
                    sum += (max - d[i]);
                    Console.Write(d[i] + "-");
                }

                printArr[ctr] = d[i+1];
                if (i != (n - 1))
                    ctr++;
            }
            printArr[ctr++] = max;

            for (i = 0; i < dloc + 1; i++)
            {
                if (i == 0)
                {
                    sum += max;
                    Console.Write(min + "-");
                    printArr[ctr] = min;
                }
                else if (i - 1 == 0)
                {
                    sum += Math.Abs(d[i - 1] - min);
                    Console.Write(d[i - 1] + "-=");
                    printArr[ctr] = d[i - 1];
                }
                else
                {
                    sum += Math.Abs((d[i - 2] - d[i - 1]));
                    Console.Write(d[i - 1]);
                    if (i != (dloc - 2))
                        Console.Write("-|");
                    printArr[ctr] = d[i - 1];
                }
                ctr++;
            }

            Console.WriteLine("\nTotal Head Movement: " + sum);
            this.txt_totalHead.Text = sum.ToString();
            generateChart(printArr, disk, n+1);

        }

        public void look(int[] d, int disk, int n)
        {

            Console.WriteLine("\nSHOW LOOK");
            // Initialization 
            int i, j, sum = 0, min = 0 ;  
            int temp, max = 200;
            int dloc;   //loc of disk in array
            int[] printArr = new int[20]; 
             
            d[n] = disk;
            n = n + 1;
            for (i = 0; i < n; i++)    // sorting disk locations
            {
                for (j = i; j < n; j++)
                {
                    if (d[i] > d[j])
                    {
                        temp = d[i];
                        d[i] = d[j];
                        d[j] = temp;
                    }
                }
            }
            dloc = 0;
            for (i = 0; i < n; i++)   // to find loc of disc in array
            {
                if (disk == d[i]) { dloc = i; break; }
            } 
            int ctr = 0;
            printArr[ctr++] = disk;
            for (i = dloc + 1; i < n; i++)
            {

                sum += Math.Abs(d[i] - d[i - 1]);
                printArr[ctr++] = d[i];
                Console.Write(d[i] + "-");

            }
            for (i = dloc; i >= 0; i--)
            {

                if (i == 0) break;
                Console.Write(d[i-1] + "-");
                printArr[ctr++] = d[i-1];
                if (i == dloc)
                    sum += Math.Abs(d[n - 1] - d[i - 1]);
                else
                    sum += Math.Abs(d[i] - d[i - 1]);

            }

            Console.WriteLine("\nTotal Head Movement: " + sum);
            this.txt_totalHead.Text = sum.ToString();
            generateChart(printArr, disk, n);
        }

        public void clook(int[] d, int disk, int n)
        {

            Console.WriteLine("\nSHOW C-LOOK");
            // Initialization 
            int i, j, sum = 0, min = 0 ;  
            int temp, max = 200;
            int[] printArr = new int[20];
            int dloc;   //loc of disk in array
           
            d[n] = disk;
            n = n + 1;
            for (i = 0; i < n; i++)    // sorting disk locations
            {
                for (j = i; j < n; j++)
                {
                    if (d[i] > d[j])
                    {
                        temp = d[i];
                        d[i] = d[j];
                        d[j] = temp;
                    }
                }
            }
            dloc = 0;
            for (i = 0; i < n; i++)   // to find loc of disc in array
            {
                if (disk == d[i]) { dloc = i; break; }
            } 
            int ctr = 0;
            printArr[ctr++] = disk;
            for (i = dloc + 1; i < n; i++)
            {

                sum += Math.Abs(d[i] - d[i - 1]);
                Console.Write(d[i] + "-");
                printArr[ctr++] = d[i];
            }
            for (i = 0; i < dloc; i++)
            {
                if (i == 0)
                    sum += Math.Abs(d[n - 1] - d[i]);
                else
                    sum += Math.Abs(d[i] - d[i - 1]);

                Console.Write(d[i] + "-");


                printArr[ctr++] = d[i];
            }
            Console.Write("=" + ctr + "=");
            for(int k =0;k < n; k++)
            {
                Console.Write(printArr[k] + "=>");
            }
            Console.WriteLine("\nTotal Head Movement: " + sum);
            this.txt_totalHead.Text = sum.ToString();
            generateChart(printArr, disk, n);
        }

        // Calculates difference of each  
        // track number with the head position 
        public static void calculateDifference(int[] queue,
                                            int head, node[] diff)

        {
            for (int i = 0; i < diff.Length; i++)
                diff[i].distance = Math.Abs(queue[i] - head);
        }

        // find unaccessed track  
        // which is at minimum distance from head 
        public static int findMin(node[] diff)
        {
            int index = -1, minimum = int.MaxValue;

            for (int i = 0; i < diff.Length; i++)
            {
                if (!diff[i].accessed && minimum > diff[i].distance)
                {

                    minimum = diff[i].distance;
                    index = i;
                }
            }
            return index;
        }

        public void shortestSeekTimeFirst(int[] request,
                                                        int head, int n)
        {
            if (request.Length == 0)
                return;

            // create array of objects of class node  
            node[] diff = new node[n];

            // initialize array 
            for (int i = 0; i < diff.Length; i++)

                diff[i] = new node();

            // count total number of seek operation  
            int seek_count = 0;

            // stores sequence in which disk access is done 
            int[] seek_sequence = new int[n + 1];

            for (int i = 0; i < n; i++)
            {

                seek_sequence[i] = head;
                calculateDifference(request, head, diff);

                int index = findMin(diff);

                diff[index].accessed = true;

                // increase the total count 
                seek_count += diff[index].distance;

                // accessed track is now new head 
                head = request[index];
            }

            // for last accessed track 
            seek_sequence[seek_sequence.Length - 1] = head;

            Console.WriteLine("\nTotal number of seek operations = "
                                                        + seek_count);

            Console.WriteLine("\nSeek Sequence is");

            // print the sequence 
            for (int i = 0; i < seek_sequence.Length; i++)
            {
                Console.Write(seek_sequence[i]);
                if (i != seek_sequence.Length - 1) Console.Write(" -> ");
            }
            this.txt_totalHead.Text = seek_count.ToString();
            generateChart(seek_sequence, head, seek_sequence.Length);
        }

        private void Cb_diskSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            clearChart();
            clearValues();
        }

        public bool emptyField(TextBox tb)
        {
            if (String.IsNullOrEmpty(tb.Text))
            {
                return true;
            }
            return false;
        }

        public void generateChart(int[] tracks, int disk, int n)
        {
            clearChart();
            Series series = new Series();
            series.Name = "tracks";
            series.IsVisibleInLegend = false;
            series.IsXValueIndexed = true;
            series.XValueType = ChartValueType.Time;
            series.YAxisType = AxisType.Primary;
            series.ChartType = SeriesChartType.Line;
            this.chartDisk.Series.Add(series);

            this.chartDisk.Series["tracks"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Triangle;
            this.chartDisk.Series["tracks"].MarkerSize = 16;
            this.chartDisk.Series["tracks"].MarkerColor = Color.Black;
            if( (this.schedule.Trim().ToUpper().Equals("FCFS")  ) )
                this.chartDisk.Series["tracks"].Points.AddXY("HEAD", disk);


            for (int i = 0; i < n; i++)
            {
                string labelTrack = "Track ";
                if ( (this.schedule.Trim().ToUpper().Equals("FCFS")) && i == 0 )
                    this.chartDisk.Series["tracks"].Points.AddXY("HEAD", tracks[i]);
                else
                    this.chartDisk.Series["tracks"].Points.AddXY(labelTrack, tracks[i]);
            }

        }

        public void clearValues()
        {
            txt_track1.Text = null;
            txt_track2.Text = null;
            txt_track3.Text = null;
            txt_track4.Text = null;
            txt_track5.Text = null;
            txt_track6.Text = null;
            txt_track7.Text = null;
            txt_track8.Text = null;
            txt_headmovement.Text = null;
            txt_totalHead.Text = null;
        }

        public void clearChart()
        {
            this.chartDisk.Series.Clear();
        }

    }

    public class node
    {

        // represent difference between  
        // head position and track number 
        public int distance = 0;

        // true if track has been accessed 
        public Boolean accessed = false;
    }
}
