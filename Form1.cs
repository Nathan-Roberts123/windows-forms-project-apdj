using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_deve_practical_project
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            GymnasiumRadio.Checked = true;
            Radio1hour.Checked = true;
            StudentRadio.Checked = true;
        }

        private void SwimmingPoolRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(MembershipNumber.Text))
                {
                    throw new NullReferenceException("You must enter your membership number");
                }

                if (StudentRadio.Checked || StaffRadio.Checked)
                {
                    message.Text = "Booking of facilities for student and staff is free of change";
                }
                else
                {
                    if (SquashCourtRadio.Checked == true)
                    {
                        if (Radio30min.Checked == true)
                        {
                            if (weekend.Checked == true)
                            {
                                message.Text = " ";

                            } else
                            {
                                message.Text = " ";

                            }

                        }
                        else if (Radio1hour.Checked == true)
                        {
                            if (weekend.Checked == true)
                            {
                                message.Text = " ";

                            }
                            else
                            {
                                message.Text = " ";

                            }

                        }
                        else if (Radio90min.Checked == true)
                        {
                            if (weekend.Checked == true)
                            {
                                message.Text = " ";

                            }
                            else
                            {
                                message.Text = " ";

                            }

                        }
                        else if (Radio2hour.Checked == true)
                        {
                            if (weekend.Checked == true)
                            {
                                message.Text = " ";

                            }
                            else
                            {
                                message.Text = " ";

                            }

                        }
                    }

                    else if (SwimmingPoolRadio.Checked == true)
                    {
                        if (Radio30min.Checked == true)
                        {
                            if (weekend.Checked == true)
                            {
                                message.Text = " ";


                            }
                            else
                            {
                                message.Text = " ";

                            }

                        }
                        else if (Radio1hour.Checked == true)
                        {
                            if (weekend.Checked == true)
                            {
                                message.Text = " ";

                            }
                            else
                            {
                                message.Text = " ";

                            }

                        }
                        else if (Radio90min.Checked == true)
                        {
                            if (weekend.Checked == true)
                            {
                                message.Text = " ";

                            }
                            else
                            {
                                message.Text = " ";

                            }

                        }
                        else if (Radio2hour.Checked == true)
                        {
                            if (weekend.Checked == true)
                            {
                                message.Text = " ";

                            }
                            else
                            {
                                message.Text = " ";

                            }

                        }
                    }

                    else if (GymnasiumRadio.Checked == true)
                    {
                        if (Radio30min.Checked == true)
                        {
                            if (weekend.Checked == true)
                            {
                                message.Text = " ";

                            }
                            else
                            {
                                message.Text = " ";

                            }

                        }
                        else if (Radio1hour.Checked == true)
                        {
                            if (weekend.Checked == true)
                            {
                                message.Text = " ";

                            }
                            else
                            {
                                message.Text = " ";

                            }

                        }
                        else if (Radio90min.Checked == true)
                        {
                            if (weekend.Checked == true)
                            {
                                message.Text = " ";

                            }
                            else
                            {
                                message.Text = " ";

                            }

                        }
                        else if (Radio2hour.Checked == true)
                        {
                            if (weekend.Checked == true)
                            {
                                message.Text = " ";

                            }
                            else
                            {
                                message.Text = " ";

                            }

                        }
                    }

                    else if (WeightsRadio.Checked == true)
                    {
                        if (Radio30min.Checked == true)
                        {
                            if (weekend.Checked == true)
                            {
                                message.Text = " ";

                            }
                            else
                            {
                                message.Text = " ";

                            }

                        }
                        else if (Radio1hour.Checked == true)
                        {
                            if (weekend.Checked == true)
                            {
                                message.Text = " ";

                            }
                            else
                            {
                                message.Text = " ";

                            }

                        }
                        else if (Radio90min.Checked == true)
                        {
                            if (weekend.Checked == true)
                            {
                                message.Text = " ";
                            }
                            else
                            {
                                message.Text = " ";

                            }

                        }
                        else if (Radio2hour.Checked == true)
                        {
                            if (weekend.Checked == true)
                            {
                                message.Text = " ";

                            }
                            else
                            {
                                message.Text = " ";

                            }

                        }
                    }
                }

            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            

        }
    }
}
