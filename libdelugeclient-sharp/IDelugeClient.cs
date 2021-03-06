// 
// IDelugeClient.cs
//  
// Author:
//       Bojan Rajkovic <brajkovic@coderinserepeat.com>
// 
// Copyright (c) 2011 Bojan Rajkovic
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using System.Collections.Generic;

namespace CodeRinseRepeat.Deluge
{
	public interface IDelugeClient
	{
		Torrent GetTorrentStatus (Torrent t, string[] fields);
		Torrent GetTorrentStatus (Torrent t);
		void GetTorrentStatus (Torrent t, string[] fields, Action<Torrent> callback);
		void GetTorrentStatus (Torrent t, Action<Torrent> callback);

		void RescanPlugins ();

		bool Login (string password);
		void Login (string password, Action<bool> callback);

		string ListMethods ();
		void ListMethods (Action<string> callback);

		IEnumerable<Torrent> GetTorrents ();
		void GetTorrents (Action<IEnumerable<Torrent>> callback);

		IEnumerable<string> GetAvailablePlugins ();
		void GetAvailablePlugins (Action<IEnumerable<string>> callback);
	}
}

