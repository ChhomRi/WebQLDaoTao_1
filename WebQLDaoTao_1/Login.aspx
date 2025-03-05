<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebQLDaoTao_1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng Nhập</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css" />
    <style>
        body {
            background: linear-gradient(135deg, #E6A9EC, #8A2BE2); /* Gradient từ tím nhạt đến tím đậm */
            height: 100vh;
            display: flex;
            align-items: center;
            justify-content: center;
            margin: 0;
            overflow: hidden;
            animation: backgroundAnimation 8s ease infinite;
        }

        @keyframes backgroundAnimation {
            0% {
                background: linear-gradient(135deg, #E6A9EC, #8A2BE2);
            }

            50% {
                background: linear-gradient(135deg, #DDA0DD, #9370DB);
            }

            100% {
                background: linear-gradient(135deg, #E6A9EC, #8A2BE2);
            }
        }

        .container {
            background: #ff00dc;
            padding: 30px;
            border-radius: 10px;
            box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.1);
            max-width: 400px;
            width: 100%;
            transition: transform 0.3s ease, box-shadow 0.3s ease;
        }

            .container:hover {
                transform: scale(1.05);
                box-shadow: 0px 0px 15px rgba(0, 0, 0, 0.2);
            }

        .btn-primary {
            background: #228B22;
            border: none;
            padding: 12px 25px;
            font-size: 16px;
            border-radius: 5px;
            transition: all 0.3s ease-in-out;
            box-shadow: 0px 4px 8px rgba(0, 0, 0, 0.2);
        }

            .btn-primary:hover {
                background: #7CFC00;
                transform: scale(1.1);
                box-shadow: 0 0 12px rgba(0, 0, 0, 0.3);
            }

        .btn-link {
            color: #00ff7f;
            text-decoration: none;
            font-size: 14px;
        }

            .btn-link:hover {
                color: #006400;
                text-decoration: underline;
            }

        .leaf {
            position: absolute;
            top: -50px;
            color: #e91e63;
            font-size: 1.5em;
            pointer-events: none;
            animation: fall linear infinite;
        }

        @keyframes fall {
            0% {
                transform: translateY(0) rotate(0deg);
                opacity: 1;
            }

            100% {
                transform: translateY(100vh) rotate(360deg);
                opacity: 0;
            }
        }

        @media (max-width: 480px) {
            .container {
                padding: 20px;
            }
        }

        .loading {
            pointer-events: none;
            opacity: 0.7;
        }

            .loading::after {
                content: " ...";
                animation: dots 1.5s infinite;
            }
            .leaf {
        position: fixed;
        top: -5vh;
        color: red;
        user-select: none;
        animation: fall linear infinite;
    }

    @keyframes fall {
        to {
            transform: translateY(100vh);
        }
    }
    </style>


</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2 class="text-center">Đăng Nhập</h2>
            <div class="form-group">
                <label for="txtUsername">Tên đăng nhập:</label>
                <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" aria-label="Tên đăng nhập"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtPassword">Mật khẩu:</label>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password" aria-label="Mật khẩu"></asp:TextBox>
            </div>
            <asp:Label ID="lblMessage" runat="server" CssClass="text-danger"></asp:Label>
            <div class="form-group text-center">
                <asp:Button ID="btLogin" runat="server" Text="Đăng nhập" CssClass="btn btn-primary" OnClick="btLogin_Click" />
            </div>

        </div>
    </form>
    <script>
        const leafCount = 100; // Số lượng trái tim rơi (giảm số lượng để không quá nặng)
        const container = document.body;

        for (let i = 0; i < leafCount; i++) {
            const leaf = document.createElement("div");
            leaf.classList.add("leaf");
            leaf.textContent = "❤️"; // Thay hoa thành trái tim
            leaf.style.left = Math.random() * 100 + "vw";
            leaf.style.animationDuration = Math.random() * 5 + 5 + "s";
            leaf.style.fontSize = Math.random() * 1.5 + 1 + "em";
            leaf.style.opacity = Math.random();
            leaf.style.position = "fixed";
            leaf.style.zIndex = "9999"; // Đảm bảo hiển thị trên cùng
            container.appendChild(leaf);
        }
    </script>
</body>
</html>
