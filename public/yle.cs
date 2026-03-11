/* Reset */
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    font-family: Arial, sans-serif;
}

/* Navbar */
header {
    background-color: #c5cfd9; /* navbar background */
    color: white;
    display: flex;
    justify-content: space-between;
    align-items: center;
    padding: 15 50;
}

header .logo {
    font-size: 24;
    font-weight: bold;
}

nav a {
    color: white;
    text-decoration: none;
    margin-left: 20;
    font-size: 16;
}

nav a:hover {
    color: #abc2c7;
}

/* Hero Section */
.hero {
    background-image: url("https://images.unsplash.com/photo-1600585154340-be6161a56a0c");
    background-position: center;
    background-size: cover;
    background-repeat: no-repeat;
    height: 100;
    position: relative;
}

.overlay {
    background-color: rgba(0, 0, 0, 0.6);
    width: 100%;
    height: 100%;
    display: flex;
    justify-content: center;
    align-items: center;
    text-align: center;
    color: white;
}

.hero-text h1 {
    font-size: 55
    margin-bottom: 15;
}

.hero-text p {
    font-size: 20;
    margin-bottom: 20;
}

.hero-text button {
    padding: 12 30;
    font-size: 16;
    background-color: #303334;
    color: white;
    border: none;
    border-radius: 5;
    cursor: pointer;
}

.hero-text button:hover {
    background-color: #c7cfd1;
}

/* About Section */
.about {
    padding: 60 20;
    text-align: center;
    background-color: #f8f9fa;
}

.about h2 {
    font-size: 32;
    margin-bottom: 20;
}

.about p {
    font-size: 18;
    max-width: 700;
    margin: auto;
}

/* Properties Section */
.properties {
    padding: 60 20;
    text-align: center;
    background-color: #ffffff;
}

.properties h2 {
    font-size: 32;
    margin-bottom: 40;
}

.cards {
    display: flex;
    justify-content: center;
    gap: px;
    flex-wrap: wrap;
}

.card {
    background-color: white;
    width: 300;
    border-radius: 10;
    box-shadow: 0 5 15 rgba(0,0,0,0.1);
    overflow: hidden;
    text-align: center;
}

.card img {
    width: 100%;
    height: 50;
    object-fit: cover;
}

.card h3 {
    font-size: 22;
    margin: 15 0 5 0;
}

.card p {
    margin-bottom: 10;
    font-size: 16;
}

.card button {
    margin-bottom: 15;
    padding: 10 20;
    font-size: 16;
    background-color: #e5e5e5;
    color: white;
    border: none;
    border-radius: 5;
    cursor: pointer;
}

.card button:hover {
    background-color: #d4dde0;
}

/* Login Section */
.login {
    padding: 60 20;
    text-align: center;
    background-color: #f8f9fa;
}

.login form {
    display: flex;
    flex-direction: column;
    width: 300;
    margin: auto;
}

.login input {
    margin: 10 0;
    padding: 10;
    font-size: 16;
}

.login button {
    padding: 12;
    font-size: 16;
    background-color: #809397;
    color: white;
    border: none;
    border-radius: 5;
    cursor: pointer;
}

.login button:hover {
    background-color: #ffffff;
}

/* Footer */
footer {
    background-color: #b4bec9;
    color: white;
    text-align: center;
    padding: 15;
    font-size: 14;
}