using Kayak;
using Kayak.Framework;
using System;
using System.Net;
using System.Windows.Forms;

namespace RvtBcfApiExampleClient
{
  public partial class ServerLoginUI : Form
  {
    public string sAuthCode { get; set; }

    public ServerLoginUI( string authEndpointUrl )
    {
      InitializeComponent();

      webBrowser1.Url = new Uri( authEndpointUrl );

      var server = new KayakServer();
      server.UseFramework();
      server.Start( new IPEndPoint( IPAddress.Any, 25512 ) );

      this.FormClosing += ( s, e ) => server.Stop();
    }
  }
}
