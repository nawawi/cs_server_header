using System;
using System.Web;

/*
Add this configuration at web.config
<modules>
    <add name="ServerHeader" type="RutwebWs.ServerHeader" />
</modules>
*/

namespace RutwebWs {
	public class ServerHeader : IHttpModule {
		public void Init( HttpApplication context ) {
			context.PreSendRequestHeaders += OnPreSendRequestHeaders;
		}

		public void Dispose() { }

		private void OnPreSendRequestHeaders( object sender, EventArgs e ) {
			HttpContext.Current.Response.Headers.Set( "Server", "rutweb/WS -- http://rutweb.com" );
		}
	}
}
