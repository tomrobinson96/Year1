using System;

namespace TomDickHarry
{
	public class Person
	{
		private string firstName;
		/// <summary>
		/// Gets or sets the first name.
		/// </summary>
		/// <value>The first name.</value>
		public string FirstName {
			get {
				return firstName;
			}
			set {
				firstName = value;
			}
		}

		private string lastName;
		/// <summary>
		/// Gets or sets the last name.
		/// </summary>
		/// <value>The last name.</value>
		public string LastName {
			get {
				return lastName;
			}
			set {
				lastName = value;
			}
		}

		private string jobTitle;
		/// <summary>
		/// Gets or sets the job title.
		/// </summary>
		/// <value>The job title.</value>
		public string JobTitle {
			get {
				return jobTitle;
			}
			set {
				jobTitle = value;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="TomDickHarry.Person"/> class.
		/// </summary>
		/// <param name="fn">Fn.</param>
		/// <param name="ln">Ln.</param>
		/// <param name="jt">Jt.</param>
		public Person ( string fn, string ln, string jt )
		{
			this.FirstName = fn;
			this.LastName = ln;
			this.JobTitle = jt;
		}
	}
}

