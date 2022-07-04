locals {
    lambda_zip_location = "outputs/AWSLambda.zip"
}

data "archive_file" "AWSLambda" {
  type        = "zip"
  source_dir = "../bin/Debug/net6.0/"
  output_path = local.lambda_zip_location
}

resource "aws_lambda_function" "test_lambda" {
  filename      = local.lambda_zip_location
  function_name = "FunctionHandler"
  role          = aws_iam_role.lambda_role.arn
  handler       = "AWSLambda::AWSLambda.Function::FunctionHandler"

  # source_code_hash = filebase64sha256(local.lambda_zip_location)

  runtime = "dotnet6"
}