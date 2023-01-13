// p.109

namespace Calculator
{
  public partial class From1 : Form
  {
    InitializeComponent();
  }
  
  private void button1_Click(object sender, EventArgs e)
  {
    //　➊ int型の変数５個を宣言
    int price, quantity, subtotal, tax, total;
    
    //　➋　消費税率0.1を定数TAX_RATEに格納
    const double TAX_RATE = 0.1;
    
    //　➌　textBox1.Textで単価取得、int(Int32)型に変換
    price = Convert.ToInt32(textBox1.text);
    
    //　➍　textBox2.Textで数量を取得し、int(Int32)型に変換
    quantity = Convert.ToInt32(textBox2.text);
    
    //　➎単価に数量をかけて税抜き価格を求める
    subtotal = price * quantity;
    
    //　➏　税抜き価格に税率を掛けて消費税額を求め、
    //　double型をint型にキャストしてtaxに代入
    tax = (int)(subtotal * TAX_RATE);
    
    //　➐　税込み価格を求める
    total = subtotal + tax;
    

    //　➑　税抜き価格、消費税額、税込み価格をstring型にキャストして各ラベルに出力する
      //　label6.Text = Convert.ToString(subtotal);
      //　label7.Text = Convert.ToString(tax);
      //　label18.Text = Convert.ToString(total);
          
    //　➑-B　書式設定して各ラベルに出力する
      label6.Text = String.Format("{0:0,000}円", subtotal); 
      label7.Text = String.Format("{0:0,000}円", tax);   
      label18.Text = String.Format("{0:0,000}円", total); 
    }
  }
}
