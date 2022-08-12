using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunwayIncursion
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        #region Taxiway
        private void uEZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            panel102.Visible = true;
            label1.Visible = true;
            comboBox1.Visible = true;
            panel2.Visible = true;
        }       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "TWY E")
            {
                panel3.Visible = true;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = true;
                panel7.Visible = true;
                panel8.Visible = true;
                panel9.Visible = true;
                panel10.Visible = true;
                panel11.Visible = true;
                panel12.Visible = true;
                panel13.Visible = true;
                panel14.Visible = true;
                panel15.Visible = true;
                panel16.Visible = true;
                panel17.Visible = true;
                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
                panel21.Visible = false;
                panel22.Visible = false;
                panel23.Visible = false;
                panel24.Visible = false;
                panel25.Visible = false;
                panel26.Visible = false;
                panel27.Visible = false;
                panel28.Visible = false;
                panel29.Visible = false;
                panel30.Visible = false;
                panel31.Visible = false;
                panel32.Visible = false;
                panel33.Visible = false;
                panel34.Visible = false;
                panel35.Visible = false;
                panel36.Visible = false;
                panel37.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;
                panel40.Visible = false;
                panel41.Visible = false;
                panel42.Visible = false;
                panel43.Visible = false;
                panel44.Visible = false;
                panel45.Visible = false;
                panel46.Visible = false;
                panel47.Visible = false;
                panel48.Visible = false;
                panel49.Visible = false;
                panel50.Visible = false;
                panel51.Visible = false;
                panel52.Visible = false;
                panel53.Visible = false;
                panel54.Visible = false;
                panel55.Visible = false;
                panel56.Visible = false;
                panel57.Visible = false;
                panel58.Visible = false;
                panel59.Visible = false;
                panel60.Visible = false;
                panel61.Visible = false;
                panel62.Visible = false;
                panel63.Visible = false;
                panel64.Visible = false;
                panel65.Visible = false;
                panel66.Visible = false;
                panel67.Visible = false;
                panel68.Visible = false;
                panel69.Visible = false;
                panel70.Visible = false;
                panel71.Visible = false;
                panel72.Visible = false;
                panel73.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;
                panel76.Visible = false;
                panel77.Visible = false;
                panel78.Visible = false;
                panel79.Visible = false;
                panel80.Visible = false;
                panel81.Visible = false;
                panel82.Visible = false;
                panel83.Visible = false;
                panel84.Visible = false;
                panel85.Visible = false;
                panel86.Visible = false;
                panel87.Visible = false;
                panel88.Visible = false;
                panel89.Visible = false;
                panel90.Visible = false;
                panel91.Visible = false;
                panel92.Visible = false;
                panel93.Visible = false;
                panel94.Visible = false;
                panel95.Visible = false;
                panel96.Visible = false;
                panel97.Visible = false;
                panel98.Visible = false;

                panel99.Visible = true;
                panel100.Visible = true;
                panel101.Visible = false;

                panel103.Visible = false;
                panel104.Visible = false;
                panel105.Visible = false;

            }

           else  if (comboBox1.SelectedItem.ToString() == "TWY L")
           {
                panel3.Visible = false;
                panel4.Visible = true;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
                panel10.Visible = false;
                panel11.Visible = false;
                panel12.Visible = false;
                panel13.Visible = false;
                panel14.Visible = false;
                panel15.Visible = false;
                panel16.Visible = false;
                panel17.Visible = false;
                panel18.Visible = true;
                panel19.Visible = true;
                panel20.Visible = true;
                panel21.Visible = true;
                panel22.Visible = true;
                panel23.Visible = true;
                panel24.Visible = true;
                panel25.Visible = true;
                panel26.Visible = true;
                panel27.Visible = true;
                panel28.Visible = true;
                panel29.Visible = true;
                panel30.Visible = true;
                panel31.Visible = true;
                panel32.Visible = true;
                panel33.Visible = true;
                panel34.Visible = true;
                panel35.Visible = true;
                panel36.Visible = true;
                panel37.Visible = true;
                panel38.Visible = true;
                panel39.Visible = true;
                panel40.Visible = true;
                panel41.Visible = true;
                panel42.Visible = false;
                panel43.Visible = false;
                panel44.Visible = false;
                panel45.Visible = false;
                panel46.Visible = false;
                panel47.Visible = false;
                panel48.Visible = false;
                panel49.Visible = false;
                panel50.Visible = false;
                panel51.Visible = false;
                panel52.Visible = false;
                panel53.Visible = false;
                panel54.Visible = false;
                panel55.Visible = false;
                panel56.Visible = false;
                panel57.Visible = false;
                panel58.Visible = false;
                panel59.Visible = false;
                panel60.Visible = false;
                panel61.Visible = false;
                panel62.Visible = false;
                panel63.Visible = false;
                panel64.Visible = false;
                panel65.Visible = false;
                panel66.Visible = false;
                panel67.Visible = false;
                panel68.Visible = false;
                panel69.Visible = false;
                panel70.Visible = false;
                panel71.Visible = false;
                panel72.Visible = false;
                panel73.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;
                panel76.Visible = false;
                panel77.Visible = false;
                panel78.Visible = false;
                panel79.Visible = false;
                panel80.Visible = false;
                panel81.Visible = false;
                panel82.Visible = false;
                panel83.Visible = false;
                panel84.Visible = false;
                panel85.Visible = false;
                panel86.Visible = false;
                panel87.Visible = false;
                panel88.Visible = false;
                panel89.Visible = false;
                panel90.Visible = false;
                panel91.Visible = false;
                panel92.Visible = false;
                panel93.Visible = false;
                panel94.Visible = false;
                panel95.Visible = false;
                panel96.Visible = false;
                panel97.Visible = false;
                panel98.Visible = false;
                panel99.Visible = false;
                panel100.Visible = false;
                panel101.Visible = false;
                panel103.Visible = false;
                panel104.Visible = false;
                panel105.Visible = false;
            }

            else if (comboBox1.SelectedItem.ToString() == "TWY J")
            {

                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = true;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
                panel10.Visible = false;
                panel11.Visible = false;
                panel12.Visible = false;
                panel13.Visible = false;
                panel14.Visible = false;
                panel15.Visible = false;
                panel16.Visible = false;
                panel17.Visible = false;
                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
                panel21.Visible = false;
                panel22.Visible = false;
                panel23.Visible = false;
                panel24.Visible = false;
                panel25.Visible = false;
                panel26.Visible = false;
                panel27.Visible = false;
                panel28.Visible = false;
                panel29.Visible = false;
                panel30.Visible = false;
                panel31.Visible = false;
                panel32.Visible = false;
                panel33.Visible = false;
                panel34.Visible = false;
                panel35.Visible = false;
                panel36.Visible = false;
                panel37.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;
                panel40.Visible = false;
                panel41.Visible = false;
                panel42.Visible = true;
                panel43.Visible = true;
                panel44.Visible = true;
                panel45.Visible = true;
                panel46.Visible = true;
                panel47.Visible = true;
                panel48.Visible = true;
                panel49.Visible = true;
                panel50.Visible = true;
                panel51.Visible = true;
                panel52.Visible = true;
                panel53.Visible = true;
                panel54.Visible = true;
                panel55.Visible = true;
                panel56.Visible = true;
                panel57.Visible = true;
                panel58.Visible = true;
                panel59.Visible = true;
                panel60.Visible = false;
                panel61.Visible = false;
                panel62.Visible = false;
                panel63.Visible = false;
                panel64.Visible = false;
                panel65.Visible = false;
                panel66.Visible = false;
                panel67.Visible = false;
                panel68.Visible = false;
                panel69.Visible = false;
                panel70.Visible = false;
                panel71.Visible = false;
                panel72.Visible = false;
                panel73.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;
                panel76.Visible = false;
                panel77.Visible = false;
                panel78.Visible = false;
                panel79.Visible = false;
                panel80.Visible = false;
                panel81.Visible = false;
                panel82.Visible = false;
                panel83.Visible = false;
                panel84.Visible = false;
                panel85.Visible = false;
                panel86.Visible = false;
                panel87.Visible = false;
                panel88.Visible = false;
                panel89.Visible = false;
                panel90.Visible = false;
                panel91.Visible = false;
                panel92.Visible = false;
                panel93.Visible = false;
                panel94.Visible = false;
                panel95.Visible = false;
                panel96.Visible = false;
                panel97.Visible = false;
                panel98.Visible = false; 
                panel99.Visible = false;
                panel100.Visible = false;
                panel101.Visible = false;
                panel103.Visible = false;
                panel104.Visible = false;
                panel105.Visible = false;
            }

            else if (comboBox1.SelectedItem.ToString() == "TWY P")
            {
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
                panel10.Visible = false;
                panel11.Visible = false;
                panel12.Visible = false;
                panel13.Visible = false;
                panel14.Visible = false;
                panel15.Visible = false;
                panel16.Visible = false;
                panel17.Visible = false;
                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
                panel21.Visible = false;
                panel22.Visible = false;
                panel23.Visible = false;
                panel24.Visible = false;
                panel25.Visible = false;
                panel26.Visible = false;
                panel27.Visible = false;
                panel28.Visible = false;
                panel29.Visible = false;
                panel30.Visible = false;
                panel31.Visible = false;
                panel32.Visible = false;
                panel33.Visible = false;
                panel34.Visible = false;
                panel35.Visible = false;
                panel36.Visible = false;
                panel37.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;
                panel40.Visible = false;
                panel41.Visible = false;
                panel42.Visible = false;
                panel43.Visible = false;
                panel44.Visible = false;
                panel45.Visible = false;
                panel46.Visible = false;
                panel47.Visible = false;
                panel48.Visible = false;
                panel49.Visible = false;
                panel50.Visible = false;
                panel51.Visible = false;
                panel52.Visible = false;
                panel53.Visible = false;
                panel54.Visible = false;
                panel55.Visible = false;
                panel56.Visible = false;
                panel57.Visible = false;
                panel58.Visible = false;
                panel59.Visible = false;
                panel60.Visible = true;
                panel61.Visible = true;
                panel62.Visible = true;
                panel63.Visible = true;
                panel64.Visible = true;
                panel65.Visible = true;
                panel66.Visible = true;
                panel67.Visible = false;
                panel68.Visible = false;
                panel69.Visible = false;
                panel70.Visible = false;
                panel71.Visible = false;
                panel72.Visible = false;
                panel73.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;
                panel76.Visible = false;
                panel77.Visible = false;
                panel78.Visible = false;
                panel79.Visible = false;
                panel80.Visible = false;
                panel81.Visible = false;
                panel82.Visible = false;
                panel83.Visible = false;
                panel84.Visible = false;
                panel85.Visible = false;
                panel86.Visible = false;
                panel87.Visible = false;
                panel88.Visible = false;
                panel89.Visible = false;
                panel90.Visible = false;
                panel91.Visible = false;
                panel92.Visible = false;
                panel93.Visible = false;
                panel94.Visible = false;
                panel95.Visible = false;
                panel96.Visible = false;
                panel97.Visible = false;
                panel98.Visible = false;
                panel99.Visible = false;
                panel100.Visible = false;
                panel101.Visible = false;
                panel103.Visible = false;
                panel104.Visible = false;
                panel105.Visible = false;
            }

            else if (comboBox1.SelectedItem.ToString() == "TWY A")
            {
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
                panel10.Visible = false;
                panel11.Visible = false;
                panel12.Visible = false;
                panel13.Visible = false;
                panel14.Visible = false;
                panel15.Visible = false;
                panel16.Visible = false;
                panel17.Visible = false;
                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
                panel21.Visible = false;
                panel22.Visible = false;
                panel23.Visible = false;
                panel24.Visible = false;
                panel25.Visible = false;
                panel26.Visible = false;
                panel27.Visible = false;
                panel28.Visible = false;
                panel29.Visible = false;
                panel30.Visible = false;
                panel31.Visible = false;
                panel32.Visible = false;
                panel33.Visible = false;
                panel34.Visible = false;
                panel35.Visible = false;
                panel36.Visible = false;
                panel37.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;
                panel40.Visible = false;
                panel41.Visible = false;
                panel42.Visible = false;
                panel43.Visible = false;
                panel44.Visible = false;
                panel45.Visible = false;
                panel46.Visible = false;
                panel47.Visible = false;
                panel48.Visible = false;
                panel49.Visible = false;
                panel50.Visible = false;
                panel51.Visible = false;
                panel52.Visible = false;
                panel53.Visible = false;
                panel54.Visible = false;
                panel55.Visible = false;
                panel56.Visible = false;
                panel57.Visible = false;
                panel58.Visible = false;
                panel59.Visible = false;
                panel60.Visible = false;
                panel61.Visible = false;
                panel62.Visible = false;
                panel63.Visible = false;
                panel64.Visible = false;
                panel65.Visible = false;
                panel66.Visible = false;
                panel67.Visible = true;
                panel68.Visible = true;
                panel69.Visible = true;
                panel70.Visible = true;
                panel71.Visible = true;
                panel72.Visible = true;
                panel73.Visible = true;
                panel74.Visible = true;
                panel75.Visible = true;
                panel76.Visible = true;
                panel77.Visible = true;
                panel78.Visible = true;
                panel79.Visible = true;
                panel80.Visible = true;
                panel81.Visible = true;
                panel82.Visible = true;
                panel83.Visible = true;
                panel84.Visible = true;
                panel85.Visible = true;
                panel86.Visible = true;
                panel87.Visible = true;
                panel88.Visible = true;
                panel89.Visible = true;
                panel90.Visible = true;
                panel91.Visible = true;
                panel92.Visible = true;
                panel93.Visible = true;
                panel94.Visible = true;
                panel95.Visible = true;
                panel96.Visible = true;
                panel97.Visible = true;
                panel98.Visible = true;
                panel99.Visible = false;
                panel100.Visible = false;
                panel101.Visible = false;
                panel103.Visible = false;
                panel104.Visible = false;
                panel105.Visible = false;
            }

            else if (comboBox1.SelectedItem.ToString() == "TWY C")
            {
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
                panel10.Visible = false;
                panel11.Visible = false;
                panel12.Visible = false;
                panel13.Visible = false;
                panel14.Visible = false;
                panel15.Visible = false;
                panel16.Visible = false;
                panel17.Visible = false;
                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
                panel21.Visible = false;
                panel22.Visible = false;
                panel23.Visible = false;
                panel24.Visible = false;
                panel25.Visible = false;
                panel26.Visible = false;
                panel27.Visible = false;
                panel28.Visible = false;
                panel29.Visible = false;
                panel30.Visible = false;
                panel31.Visible = false;
                panel32.Visible = false;
                panel33.Visible = false;
                panel34.Visible = false;
                panel35.Visible = false;
                panel36.Visible = false;
                panel37.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;
                panel40.Visible = false;
                panel41.Visible = false;
                panel42.Visible = false;
                panel43.Visible = false;
                panel44.Visible = false;
                panel45.Visible = false;
                panel46.Visible = false;
                panel47.Visible = false;
                panel48.Visible = false;
                panel49.Visible = false;
                panel50.Visible = false;
                panel51.Visible = false;
                panel52.Visible = false;
                panel53.Visible = false;
                panel54.Visible = false;
                panel55.Visible = false;
                panel56.Visible = false;
                panel57.Visible = false;
                panel58.Visible = false;
                panel59.Visible = false;
                panel60.Visible = false;
                panel61.Visible = false;
                panel62.Visible = false;
                panel63.Visible = false;
                panel64.Visible = false;
                panel65.Visible = false;
                panel66.Visible = false;
                panel67.Visible = false;
                panel68.Visible = false;
                panel69.Visible = false;
                panel70.Visible = false;
                panel71.Visible = false;
                panel72.Visible = false;
                panel73.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;
                panel76.Visible = false;
                panel77.Visible = false;
                panel78.Visible = false;
                panel79.Visible = false;
                panel80.Visible = false;
                panel81.Visible = false;
                panel82.Visible = false;
                panel83.Visible = false;
                panel84.Visible = false;
                panel85.Visible = false;
                panel86.Visible = false;
                panel87.Visible = false;
                panel88.Visible = false;
                panel89.Visible = false;
                panel90.Visible = false;
                panel91.Visible = false;
                panel92.Visible = false;
                panel93.Visible = false;
                panel94.Visible = false;
                panel95.Visible = false;
                panel96.Visible = false;
                panel97.Visible = false;
                panel98.Visible = false;
                panel99.Visible = false;
                panel100.Visible = false;
                panel101.Visible = false;
                panel103.Visible = true;
                panel104.Visible = true;
                panel105.Visible = true;

            }

            else if (comboBox1.SelectedItem.ToString() == "TWY B")
            {
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
                panel10.Visible = false;
                panel11.Visible = false;
                panel12.Visible = false;
                panel13.Visible = false;
                panel14.Visible = false;
                panel15.Visible = false;
                panel16.Visible = false;
                panel17.Visible = false;
                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
                panel21.Visible = false;
                panel22.Visible = false;
                panel23.Visible = false;
                panel24.Visible = false;
                panel25.Visible = false;
                panel26.Visible = false;
                panel27.Visible = false;
                panel28.Visible = false;
                panel29.Visible = false;
                panel30.Visible = false;
                panel31.Visible = false;
                panel32.Visible = false;
                panel33.Visible = false;
                panel34.Visible = false;
                panel35.Visible = false;
                panel36.Visible = false;
                panel37.Visible = false;
                panel38.Visible = false;
                panel39.Visible = false;
                panel40.Visible = false;
                panel41.Visible = false;
                panel42.Visible = false;
                panel43.Visible = false;
                panel44.Visible = false;
                panel45.Visible = false;
                panel46.Visible = false;
                panel47.Visible = false;
                panel48.Visible = false;
                panel49.Visible = false;
                panel50.Visible = false;
                panel51.Visible = false;
                panel52.Visible = false;
                panel53.Visible = false;
                panel54.Visible = false;
                panel55.Visible = false;
                panel56.Visible = false;
                panel57.Visible = false;
                panel58.Visible = false;
                panel59.Visible = false;
                panel60.Visible = false;
                panel61.Visible = false;
                panel62.Visible = false;
                panel63.Visible = false;
                panel64.Visible = false;
                panel65.Visible = false;
                panel66.Visible = false;
                panel67.Visible = false;
                panel68.Visible = false;
                panel69.Visible = false;
                panel70.Visible = false;
                panel71.Visible = false;
                panel72.Visible = false;
                panel73.Visible = false;
                panel74.Visible = false;
                panel75.Visible = false;
                panel76.Visible = false;
                panel77.Visible = false;
                panel78.Visible = false;
                panel79.Visible = false;
                panel80.Visible = false;
                panel81.Visible = false;
                panel82.Visible = false;
                panel83.Visible = false;
                panel84.Visible = false;
                panel85.Visible = false;
                panel86.Visible = false;
                panel87.Visible = false;
                panel88.Visible = false;
                panel89.Visible = false;
                panel90.Visible = false;
                panel91.Visible = false;
                panel92.Visible = false;
                panel93.Visible = false;
                panel94.Visible = false;
                panel95.Visible = false;
                panel96.Visible = false;
                panel97.Visible = false;
                panel98.Visible = false;
                panel99.Visible = true;
                panel100.Visible = true;
                panel101.Visible = true;
                panel103.Visible = false;
                panel104.Visible = false;
                panel105.Visible = false;

            }


        }
        #endregion

        #region Melumat
        private void məlumatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            comboBox1.Visible = false;
            panel2.Visible = false;

            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
            panel13.Visible = false;
            panel14.Visible = false;
            panel15.Visible = false;
            panel16.Visible = false;
            panel17.Visible = false;
            panel18.Visible = false;
            panel19.Visible = false;
            panel20.Visible = false;
            panel21.Visible = false;
            panel22.Visible = false;
            panel23.Visible = false;
            panel24.Visible = false;
            panel25.Visible = false;
            panel26.Visible = false;
            panel27.Visible = false;
            panel28.Visible = false;
            panel29.Visible = false;
            panel30.Visible = false;
            panel31.Visible = false;
            panel32.Visible = false;
            panel33.Visible = false;
            panel34.Visible = false;
            panel35.Visible = false;
            panel36.Visible = false;
            panel37.Visible = false;
            panel38.Visible = false;
            panel39.Visible = false;
            panel40.Visible = false;
            panel41.Visible = false;
            panel42.Visible = false;
            panel43.Visible = false;
            panel44.Visible = false;
            panel45.Visible = false;
            panel46.Visible = false;
            panel47.Visible = false;
            panel48.Visible = false;
            panel49.Visible = false;
            panel50.Visible = false;
            panel51.Visible = false;
            panel52.Visible = false;
            panel53.Visible = false;
            panel54.Visible = false;
            panel55.Visible = false;
            panel56.Visible = false;
            panel57.Visible = false;
            panel58.Visible = false;
            panel59.Visible = false;
            panel60.Visible = false;
            panel61.Visible = false;
            panel62.Visible = false;
            panel63.Visible = false;
            panel64.Visible = false;
            panel65.Visible = false;
            panel66.Visible = false;
            panel67.Visible = false;
            panel68.Visible = false;
            panel69.Visible = false;
            panel70.Visible = false;
            panel71.Visible = false;
            panel72.Visible = false;
            panel73.Visible = false;
            panel74.Visible = false;
            panel75.Visible = false;
            panel76.Visible = false;
            panel77.Visible = false;
            panel78.Visible = false;
            panel79.Visible = false;
            panel80.Visible = false;
            panel81.Visible = false;
            panel82.Visible = false;
            panel83.Visible = false;
            panel84.Visible = false;
            panel85.Visible = false;
            panel86.Visible = false;
            panel87.Visible = false;
            panel88.Visible = false;
            panel89.Visible = false;
            panel90.Visible = false;
            panel91.Visible = false;
            panel92.Visible = false;
            panel93.Visible = false;
            panel94.Visible = false;
            panel95.Visible = false;
            panel96.Visible = false;
            panel97.Visible = false;
            panel98.Visible = false;

            panel99.Visible = false;
            panel100.Visible = false;
            panel101.Visible = false;


            panel103.Visible = false;
            panel104.Visible = false;
            panel105.Visible = false;

            panel102.Visible = false;
            richTextBox1.Visible = true;

                   }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Formun_Hereketi_5
        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form5_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        #endregion

        private void panel46_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
