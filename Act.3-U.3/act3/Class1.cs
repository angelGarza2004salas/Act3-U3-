using System;

public class Class1
{
	public Class1()
	{
		// Variables
        private string name;
         private int age;

    // Builder
    public Form1(string name, int age)
    {
        InitializeComponent();
        this.name = name;
        this.age = age;
        label1.Text =  "Hello, mi name is " + this.textBox1.Text + " y tengo " + this.age + " años.";
    }

    // Métodos
    private void button1_Click(object sender, EventArgs e)
    {
        if (textBox1.Text == "")
        {
            age++;
            label1.Text = this.textBox1.Text + " alguien ha cumplido años. Ahora tiene " + this.age + " años.";
        }
        else
        {
            age++;
            label1.Text = this.textBox1.Text + " ha cumplido años. Ahora tiene " + this.age + " años.";
        }
    }

    // Destructor
    ~Form1()
    {
        Console.WriteLine("Se ha destruido el objeto Form1.");
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        Console.WriteLine("Se ha cerrado el formulario.");
    }
  }
}



