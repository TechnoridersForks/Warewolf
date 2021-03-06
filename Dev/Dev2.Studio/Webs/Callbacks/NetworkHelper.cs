/*
*  Warewolf - Once bitten, there's no going back
*  Copyright 2017 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later. 
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/

using System;
using System.Net;
using System.Threading.Tasks;

namespace Dev2.Webs.Callbacks
{
    public interface INetworkHelper
    {
        Task<bool> HasConnectionAsync(string uri);
    }

    public class NetworkHelper : INetworkHelper
    {
        public async Task<bool> HasConnectionAsync(string uri)
        {
            try
            {
                Uri theUri;
                Uri.TryCreate(uri, UriKind.RelativeOrAbsolute, out theUri);
                using (var client = new WebClient())
                {
                    await client.OpenReadTaskAsync(uri);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
