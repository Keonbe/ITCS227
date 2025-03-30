using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _4___Implementing_Master_Page.assets
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}
	}

    /*
	 Solution 2: Disable UnobtrusiveValidationMode
	If you don’t want to use unobtrusive validation, you can disable it in the web.config file.

	Steps to Fix:
	Open the web.config file in your project.
	Add or update the following configuration under the <appSettings> section:

			<configuration>
			  <appSettings>
				<add key="ValidationSettings:UnobtrusiveValidationMode" value="None" />
			  </appSettings>
			</configuration>

			[[</system.web>
			<appSettings>
				<add key="ValidationSettings:UnobtrusiveValidationMode" value="None" />
			</appSettings>
		  <system.codedom>]]

	This will disable unobtrusive validation and revert to the traditional validation mode, which does not require jQuery.
	 */
}