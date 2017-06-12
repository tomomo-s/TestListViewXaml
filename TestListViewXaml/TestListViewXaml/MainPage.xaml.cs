using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;
using System.Collections.ObjectModel;

namespace TestListViewXaml
{
    public partial class MainPage : ContentPage
	{
        /// <summary>
        /// コレクション一覧
        /// </summary>
        public class ListViewCollection
        {
            // 表情（通常、笑う、怒る）
            public string Action { get; set; }
            // 画像（通常、笑う、怒る）
            public string Image { get; set; }
        }
        /// <summary>
        /// ジェネリックコレクション設定
        /// </summary>
        public ObservableCollection<ListViewCollection> listcollection { get; set; }
        public MainPage()
		{
			InitializeComponent();
            listcollection = new ObservableCollection<ListViewCollection>();
            // コレクションにアイテムを追加
            listcollection.Add(new ListViewCollection { Action = "キリッ(｀･ω･´)", Image = "Image/normal.png" });
            listcollection.Add(new ListViewCollection { Action = "にこにこ(#^^#)", Image = "Image/smile.png" });
            listcollection.Add(new ListViewCollection { Action = "ぷんぷんヽ(`Д´)ﾉ", Image = "Image/angry.png" });
            // XAMLのListViewに設定
             listview_collection.ItemsSource = listcollection;
        }
    }
}
