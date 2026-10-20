package ar.edu.unsam.programacion3.selenium.login;

import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.boot.test.web.server.LocalServerPort;

import static org.junit.jupiter.api.Assertions.assertTrue;

@SpringBootTest(
        webEnvironment = SpringBootTest.WebEnvironment.RANDOM_PORT
)
class LoginTest {

    private WebDriver driver;

    @LocalServerPort
    private int port;

    @BeforeEach
    void configurarNavegador() {
        driver = new ChromeDriver();
    }

    @AfterEach
    void cerrarNavegador() {
        if (driver != null) {
            driver.quit();
        }
    }

    @Test
    void loginConCredencialesValidas() {
        driver.get("http://localhost:" + port);

        driver.findElement(By.id("username")).sendKeys("admin");
        driver.findElement(By.id("password")).sendKeys("1234");
        driver.findElement(By.id("btnLogin")).click();

        assertTrue(driver.getPageSource().contains("Acceso exitoso"));
    }

    @Test
    void loginConCredencialesInvalidas() {
        driver.get("http://localhost:" + port);

        driver.findElement(By.id("username")).sendKeys("admin");
        driver.findElement(By.id("password")).sendKeys("9999");
        driver.findElement(By.id("btnLogin")).click();

        assertTrue(driver.getPageSource().contains("Usuario o contraseña incorrectos"));
    }
}