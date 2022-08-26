<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Hopita_Ibn_Sina_Management.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>mplete Responsive Dentist Website</title>
    <!-- FontAwesome cdn link -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css">
    <!-- Bootstrap cdn link -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap/4.6.1/css/bootstrap.min.css">
    <!-- File css -->
    <link rel="stylesheet" href="style.css">
    <!-- File js -->
    <script src="script.js"></script>
</head>
<body>
            <!-- header section start -->
    <header class="header fixed-top">
        <div class="container">
            <div class="row align-items-center justify-content-between">

                <a href="#" class="logo">Hôpital<span> Ibn Sina</span></a>

                <nav class="nav">
                    <a href="#home">Accueil</a>
                    <a href="#about">Hôpital</a>
                    <a href="#services">Spécialités</a>
                    <a href="#reviews">Équipe</a>
                    <a href="#contact">contact</a>
                </nav>
                <a href="#contact" class="link-btn">Prendre un rendez-vous</a>
                <div id="menu-btn" class="fas fa-bars"></div>
            </div>
        </div>
    </header>

    <!-- home section started -->
    <section class="home" id="home">
        <div class="container">
            <div class="row min-vh-100 align-items-center">
                <div class="content text-center text-md-left">
                    <h3>Hôpital Ibn Sina</h3>
                    <p>Un hôpital fournissant un service de soins de santé qui fournit un traitement aux patients par du personnel médical et infirmier spécialisé et du matériel médical</p>
                    <a href="#contact" class="link-btn">Prendre un rendez-vous</a>
                </div>

            </div>
        </div>

    </section>
    <!-- about section start -->
    <section class="about" id="about">
        <div class="container">
            <div class="row align-items-center">

                <div class="col-md-6 image">
                    <img src="images/about___pic.png" class="w-100 mb-5 mb-md-0" alt="about">
                </div>

                <div class="col-md-6 content">
                    <span>Hôpital</span>
                    <h3>Hôpital Ibn Sina</h3>
                    <p>Est un établissement de soins où un personnel soignant peut prendre en charge des personnes malades ou victimes de traumatismes trop complexes pour être traités à domicile ou dans le cabinet de médecin</p>
                    <a href="#contact" class="link-btn">Prendre un rendez-vous</a>
                </div>

            </div>
        </div>
    </section>
    <!-- services section start -->
    <div class="services" id="services">

        <h1 class="heading">Notre Spécialités</h1>

        <div class="box-container container">

            <div class="box">
                <img src="images/1.png" alt="icon-1">
                <h3>ENDOCRINOLOGIE</h3>
                <p>L'endocrinologue est le spécialiste des problèmes hormonaux. Il prend en charge les pathologies liées à un dérèglement...</p>
            </div>

            <div class="box">
                <img src="images/2.png" alt="icon-2">
                <h3>OPHTALMOLOGIE</h3>
                <p>L'ophtalmologie est la spécialité qui se consacre à l'étude de la structure et du fonctionnement des yeux...</p>
            </div>

            <div class="box">
                <img src="images/3.png" alt="icon-3">
                <h3>GYNECOLOGIE</h3>
                <p>La gynécologie traite de la physiologie du système génital féminin. Toutes les maladies gynécologiques des MST aux...</p>
            </div>

            <div class="box">
                <img src="images/4.png" alt="icon-4">
                <h3>NEUROLOGIE</h3>
                <p>La neurologie est une discipline médicale qui étudie la physiologie, l'anatomie et la pathologie du système nerveux...</p>
            </div>

            <div class="box">
                <img src="images/5.png" alt="icon-5">
                <h3>ESTHETIQUE</h3>
                <p>En plus de la chirurgie esthétique, International Clinic réunit sous un même toit un département de médecine esthé...</p>
            </div>

            <div class="box">
                <img src="images/6.png" alt="icon-6">
                <h3>CARDIOLOGIE</h3>
                <p>Le cardiologue est le médecin spécialisé dans l'étude du cœur et des vaisseaux.Il suit certains patients...</p>
            </div>

        </div>

    </div>
    <!-- section process start  -->
    <section class="process">
        <h1 class="heading">les opérations chirurgicales</h1>

        <div class="box-container container">

            <div class="box">
                <img src="images/sur8.png" alt="process-1">
                <h3>La chirurgie vasculaire</h3>
                <p>C'est la chirurgie qui s'occupe des pathologies relatives aux veines et aux artères</p>
            </div>

            <div class="box">
                <img src="images/sur1.png" alt="process-2">
                <h3>La chirurgie digestive</h3>
                <p>C'est la branche qui intervient pour les maladies des organes digestifs tels que l'estomac, le côlon ou encore l'œsophage.</p>
            </div>

            <div class="box">

                <img src="images/sur5.png" alt="process-3">
                <h3>La chirurgie infantile</h3>
                <p>Il s'agit de la partie de la chirurgie prenant en charge les pathologies des nourrissons et des enfants de trois mois à 15 ans.</p>
            </div>

        </div>
    </section>
    <!-- section reviews start  -->
    <div class="reviews" id="reviews">
        <h1 class="heading">Notre Équipe</h1>

        <div class="box-container container">
            <div class="box">
                <img src="images/doc.png" alt="pic-1">
                <p>La chirurgie plastique recouvre les chirurgies réparatrice et esthétique. Rendue nécessaire historiquement à cause des guerres, à commencer par la Première Guerre mondiale, la chirurgie réparatrice.</p>
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star-half-alt"></i>
                </div>
                <h3>Dr Abdelaziz Salim</h3>
                <span>RÉANIMATEUR-ANESTHÉSISTE</span>
            </div>


            <div class="box">
                <img src="images/doc.png" alt="pic-2">
                <p>L’anesthésiste-réanimateur est un médecin qui intervient avant, pendant et après toute opération chirurgicale qui nécessite une anesthésie générale ou locorégionale.</p>
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star-half-alt"></i>
                </div>
                <h3>Dr Faycal El Kasbi</h3>
                <span>CHIRURGIE PLASTIQUE ET ESTHETIQUE</span>

            </div>

            <div class="box">
                <img src="images/doc.png" alt="pic-3">
                <p>La chirurgie plastique recouvre les chirurgies réparatrice et esthétique. Rendue nécessaire historiquement à cause des guerres, à commencer par la Première Guerre mondiale, la chirurgie réparatrice.</p>
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star-half-alt"></i>
                </div>
                <h3>Dr Yahya Yakoubi</h3>
                <span>RÉANIMATEUR-ANESTHÉSISTE</span>
            </div>
        </div>
        <!-- section contact start  -->

        <section class="contact" id="contact">

            <h1 class="heading">Prendre un rendez-vous</h1>

            <form id="form" runat="server">

                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server"><ContentTemplate>

                <span>Nom :</span>
                <%--<input type="text" name="name" placeholder="Enter your name" class="box" required>--%>
                <asp:TextBox ID="txtnom" runat="server" placeholder="taper votre nom" class="box" AutoCompleteType="Disabled"></asp:TextBox>

                <span>Prénom :</span>
                <%--<input type="text" name="name" placeholder="Enter your name" class="box" required>--%>
                <asp:TextBox ID="txtprenom" runat="server" placeholder="taper votre prénom" AutoCompleteType="Disabled" class="box"></asp:TextBox>

                <span>CIN :</span>
                <%--<input type="email" name="email" placeholder="xxx@gmail.com" class="box" required>--%>
                <asp:TextBox ID="txtcin" runat="server" placeholder="taper votre cin" class="box" AutoCompleteType="Disabled"></asp:TextBox>

                <span>Numéro Téléphone  :</span>
                <%--<input type="number" name="number" placeholder="Enter your number" class="box" required>--%>
                <asp:TextBox ID="txtphone" type="number" runat="server" placeholder="taper votre numéro télélphone" class="box"></asp:TextBox>

                <span>Date de Rendez-Vous :</span>
                <%--<input type="datetime-local" name="date" class="box" required>--%>
                <%--<asp:Calendar ID="date" runat="server" class="box"></asp:Calendar>--%>
                <asp:TextBox ID="txtdate" runat="server" type="date" class="box"></asp:TextBox>

                <asp:Label ID="txter" runat="server" ForeColor="Red"></asp:Label>
                <%--<input type="submit" value="Prendre un rendez-vous" name="submit" class="link-btn">--%>
                <asp:Button ID="pr_re_vo" runat="server" Text="Prendre un rendez-vous" class="link-btn" OnClick="pr_re_vo_Click" />

                </section>
                </ContentTemplate></asp:UpdatePanel>

            </form>

        <!-- section footer start -->
        <section class="footer">
            <div class="box-container container">

                <div class="box">
                    <i class="fas fa-phone"></i>
                    <h3>Numéro Téléphone </h3>
                    <p>+212-7014591</p>
                </div>

                <div class="box">
                    <i class="fas fa-envelope"></i>
                    <h3>E-mail </h3>
                    <p>Hôpital-Ibn-Sina@gmail.com</p>
                </div>

                <div class="box">
                    <i class="fas fa-clock"></i>
                    <h3>Heure de travail </h3>
                    <p>8:00 am to 16:00</p>
                </div>

                <div class="box">
                    <i class="fas fa-map-marker-alt"></i>
                    <h3>Notre Adresse </h3>
                    <p>Hay salam agadir avenue el farabi route n°31</p>
                </div>

            </div>
            <div class="credit">
                copyright &copy; <span>Hôpital Ibn Sina</span>

                <!-- top button -->
                <a id="top" href="#">
                    <i class="fas fa-arrow-up"></i>
                </a>

            </div>
        </section>
</body>
</html>
