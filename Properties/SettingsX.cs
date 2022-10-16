using System;

namespace nilnul.fs.git.Properties
{
	static public class SettingsX
	{

		[Obsolete(nameof(Clients_my),true)]
		static public git.svr.client_.accVaulted.Nameds client__noCred_Nameds
		{
			get
			{
				return Settings.Default.client__accVaulted_Nameds ?? new git.svr.client_.accVaulted.Nameds();
			}
		}

		static public git.svr.client_.accVaulted.Nameds Clients_my
		{
			get
			{
				var txt = Settings.Default.clients_my_base6four;
				if (string.IsNullOrWhiteSpace(txt))
				{
					return  new git.svr.client_.accVaulted.Nameds();
				}
				return nilnul.obj.lex_.byt_._Base64X.Deserialize5Base6four<git.svr.client_.accVaulted.Nameds>(txt);
			}
			set
			{
				Settings.Default.clients_my_base6four = nilnul.obj.lex_.byt_._Base64X.Serialize2Base6four(value);

			}
		}


		[Obsolete()]
		static public git.svr.client_.vaulted.repo.Nameds clients_pub_list
		{
			get
			{
				return Settings.Default.clients_pub_list ?? new svr.client_.vaulted.repo.Nameds();
			}
		}


		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// todo: allow vereds
		///
		[Obsolete(nameof(clients_pub_froBase64) + " shall be used as this is deserialized to null sometimes.")]
		static public svr.client.repo.sortie_.byHost.biject_.Nom1nonemptyEs clients_pub
		{
			get
			{
				return Settings.Default.clients_pub ?? new svr.client.repo.sortie_.byHost.biject_.Nom1nonemptyEs();
			}
		}


		[Obsolete("this is deserialized to null sometimes; maybe due to the versioning upgrade?")]
		static public svr.client.repo.sortie_.byHost.biject_.Nom1nonemptyEs clients_pub_froBase64
		{
			get
			{
				var txt = Settings.Default.clients_pub_base6four;
				if (string.IsNullOrEmpty(txt))
				{
					return null;
				}
				return nilnul.obj.lex_.byt_._Base64X.Deserialize5Base6four<svr.client.repo.sortie_.byHost.biject_.Nom1nonemptyEs>(txt);
			}
			set
			{
				Settings.Default.clients_pub_base6four = nilnul.obj.lex_.byt_._Base64X.Serialize2Base6four(value);

			}
		}
		static public svr.client_.vaulted.repo.names_.Dict clients_pub_dict
		{
			get
			{
				var txt = Settings.Default.clients_pub_dict;
				if (string.IsNullOrWhiteSpace(txt))
				{
					return new svr.client_.vaulted.repo.names_.Dict();
					//return null;
				}
				return nilnul.obj.lex_.byt_._Base64X.Deserialize5Base6four<svr.client_.vaulted.repo.names_.Dict>(txt);
			}
			set
			{
				Settings.Default.clients_pub_dict = nilnul.obj.lex_.byt_._Base64X.Serialize2Base6four(value);

			}
		}

	}
}
