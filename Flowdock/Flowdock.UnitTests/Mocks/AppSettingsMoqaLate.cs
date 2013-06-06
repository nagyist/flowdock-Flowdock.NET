using Flowdock.Client.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flowdock.Settings;
namespace MoqaLate.Autogenerated
{
public partial class AppSettingsMoqaLate : IAppSettings
{
// ------------ Property Username
private string _Username;
public virtual string Username
{
get { return _Username; }
set { _Username = value; }
}
public virtual void __SetUsername(string val)
{
   _Username = val;
}
// ------------ Property Password
private string _Password;
public virtual string Password
{
get { return _Password; }
set { _Password = value; }
}
public virtual void __SetPassword(string val)
{
   _Password = val;
}
// ------------ Property CurrentFlow
private Flow _CurrentFlow;
public virtual Flow CurrentFlow
{
get { return _CurrentFlow; }
set { _CurrentFlow = value; }
}
public virtual void __SetCurrentFlow(Flow val)
{
   _CurrentFlow = val;
}
}
}
