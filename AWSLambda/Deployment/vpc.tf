resource "aws_vpc" "first-vpc" {
  cidr_block = "10.0.0.0/16"

  tags = {
    Name = "dev"
  }
}

resource "aws_subnet" "first-subnet" {
  vpc_id = aws_vpc.first-vpc.id
  cidr_block = "10.0.1.0/24"
  availability_zone = "ap-southeast-2"

  tags = {
    Name = "dev-subnet"
  }
}
