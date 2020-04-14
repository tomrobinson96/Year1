using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Don_tCrossTheStreams
{
    public class Stream1
    {
        private string streamName;
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>The first name.</value>
        public string StreamName
        {
            get
            {
                return streamName;
            }
            set
            {
                streamName = value;
            }
        }

        private int wildlife;
        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        public int Wildlife
        {
            get
            {
                return wildlife;
            }
            set
            {
                wildlife = value;
            }
        }

        private bool cold;
        /// <summary>
        /// Gets or sets the job title.
        /// </summary>
        /// <value>The job title.</value>
        public bool Cold
        {
            get
            {
                return cold;
            }
            set
            {
                cold = value;
            }
        }
        private float amountOfWater;

        public float AmountOfWater
        {
            get
            {
                return amountOfWater;
            }
            set
            {
                amountOfWater = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TomDickHarry.Person"/> class.
        /// </summary>
        /// <param name="fn">Fn.</param>
        /// <param name="ln">Ln.</param>
        /// <param name="jt">Jt.</param>
        public Stream1(string sn, int wl, bool cd, float aw)
        {
            this.StreamName = sn;
            this.Wildlife = wl;
            this.Cold = cd;
            this.AmountOfWater = aw;
        }

        public Stream1()
        {
        }
    }
}