<!-- directives -->
<% @Page Language="C#" %>

<!-- code section -->
<script runat="server">

   public string textBox1 {
        get
        {
            return textBox1.Text;
        }

    }
    public string textBox2 {
        get
        {
            return textBox2.Text;
        }
    }

</script>

<!-- Layout -->

<html>
<head>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       
    </form>
</body>
</html>
