using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager.models
{
    public abstract class CPerson
    {
        public int m_iID
        {
            get;// { return m_iID; }
            set;// { m_iID = value; }
        }

        public string m_strFirstName
        {
            get; set;
        }
        public string m_strLastName
        {
           get; set;
        }

        public override string ToString()
        {
            return m_strFirstName + " " + m_strLastName;
        }
    }
}
