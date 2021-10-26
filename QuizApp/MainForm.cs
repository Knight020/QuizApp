/*
 * Created by SharpDevelop.
 * User: User
 * Date: 14/07/2021
 * Time: 10:31 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuizApp
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		double correct;
		double grade;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void Clear()
		{
			radioButton1.Checked = false;
			radioButton2.Checked = false;
			radioButton3.Checked = false;
			radioButton4.Checked = false;
			radioButton5.Checked = false;
			radioButton6.Checked = false;
			radioButton7.Checked = false;
			radioButton8.Checked = false;
			radioButton9.Checked = false;
			radioButton10.Checked = false;
			radioButton11.Checked = false;
			radioButton12.Checked = false;
			radioButton13.Checked = false;
			radioButton14.Checked = false;
			radioButton15.Checked = false;
			radioButton16.Checked = false;
			radioButton17.Checked = false;
			radioButton18.Checked = false;
			radioButton19.Checked = false;
			radioButton20.Checked = false;
			radioButton21.Checked = false;
			radioButton22.Checked = false;
			radioButton23.Checked = false;
			radioButton24.Checked = false;
			radioButton25.Checked = false;
			radioButton26.Checked = false;
			radioButton27.Checked = false;
			radioButton28.Checked = false;
			radioButton29.Checked = false;
			radioButton30.Checked = false;
			lblscore.Text = "";
			lblremarks.Text = "";
			lblgrade.Text = "";
			correct = 0;
			
			
			
		}
		
		void BtnsubmitClick(object sender, EventArgs e)
		{
			if(radioButton2.Checked)
			{
				correct+=1;
			}
			if(radioButton3.Checked)
			{
				correct+=1;
			}
			if(radioButton6.Checked)
			{
				correct+=1;
			}
			if(radioButton7.Checked)
			{
				correct+=1;
			}
			if(radioButton10.Checked)
			{
				correct+=1;
			}
			if(radioButton12.Checked)
			{
				correct+=1;
			}
			if(radioButton13.Checked)
			{
				correct+=1;
			}
			if(radioButton16.Checked)
			{
				correct+=1;
			}
			if(radioButton18.Checked)
			{
				correct+=1;
			}
			if(radioButton19.Checked)
			{
				correct+=1;
			}
			if(radioButton21.Checked)
			{
				correct+=1;
			}
			if(radioButton24.Checked)
			{
				correct+=1;
			}
			if(radioButton25.Checked)
			{
				correct+=1;
			}
			if(radioButton28.Checked)
			{
				correct+=1;
			}
			if(radioButton29.Checked)
			{
				correct+=1;
			}
			
			grade = 50 * (correct/15) + 50;
			string grades = "";
            grades = grade.ToString("#");
			if(grade>=75 && grade<=100)
			{
				lblscore.ForeColor = System.Drawing.Color.Green;
				lblgrade.ForeColor = System.Drawing.Color.Green;
				lblremarks.ForeColor = System.Drawing.Color.Green;
				lblscore.Text = correct.ToString() + "/15";
				lblgrade.Text = grades + "%";
				lblremarks.Text = "Pass";
			}
			else
			{
				lblscore.ForeColor = System.Drawing.Color.Green;
				lblgrade.ForeColor = System.Drawing.Color.Green;
				lblremarks.ForeColor = System.Drawing.Color.Red;
				lblscore.Text = correct.ToString() + "/15";
				lblgrade.Text = grades + "%";
				lblremarks.Text = "Failed";
			}
			
		}
		
		void BtnRetryClick(object sender, EventArgs e)
		{
			Clear();
			
		}
	}
}
