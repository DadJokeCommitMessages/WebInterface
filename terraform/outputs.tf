output "web_public_ip" {
  description = "The public IP address of the web server"
  value = aws_instance.dj_web[0].public_ip
}

output "web_public_dns" {
  description = "The public DNS address of the web server"
  value = aws_instance.dj_web[0].public_dns
}