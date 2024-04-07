terraform {
  required_version = ">= 0.13"
  required_providers {
    aws = {
      source  = "hashicorp/aws"
      version = "~> 3.0"
    }
  }
}

provider "aws" {
  region = "eu-west-1"
}

data "template_file" "user_data" {
  template = file("install-dotnet.sh")
}

resource "aws_instance" "dj_web" {
  ami = var.ec2_ami
  count = var.ec2_count
  instance_type = var.ec2_instance_type
  key_name = "dj_kp"
  security_groups = [element(var.ec2_sg, count.index)]
  subnet_id = var.ec2_subnet_id

  user_data = data.template_file.user_data.rendered

  tags = {
    Name = "dj_web"
    owner = "thashil.naidoo@bbd.co.za"
    created-using = "terraform"
  }
}