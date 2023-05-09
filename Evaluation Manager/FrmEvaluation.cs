using Evaluation_Manager.models;
using Evaluation_Manager.repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager {
    public partial class FrmEvaluation : Form {
        private CStudent m_Student;
        public FrmEvaluation(CStudent student) {
            InitializeComponent();
            m_Student = student;
        }

        private void cboActivities_SelectedIndexChanged(object sender, EventArgs e) {
            var activities = ActivityRepository.GetActivities();
            var currentActivity = activities[cboActivities.SelectedIndex];
            txtActivityDescription.Text = currentActivity.m_strDescription;
            txtMinforGrade.Text = currentActivity.m_iMinPointsGrade.ToString() + "/" + currentActivity.m_iMaxPoints.ToString();
            txtMinforSignature.Text = currentActivity.m_iMinPointsSignature.ToString() + "/" + currentActivity.m_iMaxPoints.ToString();

            numPoints.Minimum = 0;
            numPoints.Maximum = currentActivity.m_iMaxPoints;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void FrmEvaluation_Load(object sender, EventArgs e) {
            SetFormText();

            var activities = ActivityRepository.GetActivities();
            cboActivities.DataSource = activities;
        }
        
        private void SetFormText() {
            Text = m_Student.m_strFirstName + " " + m_Student.m_strLastName;
        }
    }
}
