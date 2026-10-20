package ar.edu.unsam.programacion3.selenium.login.controllers;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.ResponseBody;

@Controller
public class LoginController {

    @GetMapping("/")
    public String mostrarFormulario() {
        return "formulario";
    }

    @PostMapping("/login")
    @ResponseBody
    public String iniciarSesion(
            @RequestParam String username,
            @RequestParam String password) {

        if (username.equals("admin") && password.equals("1234")) {
            return "Acceso exitoso";
        } else {
            return "Usuario o contraseña incorrectos";
        }
    }
}
