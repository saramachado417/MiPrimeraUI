
public class VentanaPrincipal : Form
{
    
    public VentanaPrincipal()
    {
      InicializarElemento();
    }
    private void InicializarElemento()
    {
      this.Text = "Mi Primera Ventana";
      this.Size = new Size(300, 200);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.BackColor = Color.Brown;
      // 1. Crear
      Button boton = new Button();
      // 2. Configurar
      boton.Text = "Haz clic";
      boton.Location = new Point(50, 100);
      boton.Size = new Size(120, 35);
      // 3. Agregar a la ventana
      this.Controls.Add(boton);

      Label lblTitulo = new Label();
      lblTitulo.Text = "Registro de Personas";
      lblTitulo.Font = new Font("Segoe UI", 16, FontStyle.Bold);
      lblTitulo.Location = new Point(20, 20);
      lblTitulo.AutoSize = true;
      lblTitulo.ForeColor = Color.FromArgb(30, 30, 30);
      this.Controls.Add(lblTitulo);

      Label lblNombre = new Label();
      lblNombre.Text = "Nombre:";
      lblNombre.Location = new Point(20, 80);
      lblNombre.AutoSize = true;
      lblNombre.Font = new Font("Segoe UI", 10);
      TextBox txtNombre = new TextBox();
      txtNombre.Location = new Point(120, 77);
      txtNombre.Size = new Size(220, 30);
      txtNombre.Font = new Font("Segoe UI", 10);
      txtNombre.PlaceholderText = "Escribe tu nombre";
      Label lblEdad = new Label();
      lblEdad.Text = "Edad:";
      lblEdad.Location = new Point(20, 125);
      lblEdad.AutoSize = true;
      lblEdad.Font = new Font("Segoe UI", 10);
      TextBox txtEdad = new TextBox();
      txtEdad.Location = new Point(120, 122);
      txtEdad.Size = new Size(80, 30);
      txtEdad.Font = new Font("Segoe UI", 10);
      txtEdad.PlaceholderText = "Ej: 20";
      this.Controls.Add(lblNombre);
      this.Controls.Add(txtNombre);  
      this.Controls.Add(lblEdad);
      this.Controls.Add(txtEdad);  
    }
}