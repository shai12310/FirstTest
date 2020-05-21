pipeline 
{
	agent any
	stages 
	{
		stage ('Init')
		{
			steps
			{
				echo ### Init step ###
			}
		}
		stage ('Build')
		{
			steps
			{
				echo ### Build step ###
				bat 'nuget restore ConsoleApp1.sln'
				bat "\"${tool 'MSBuild'}\" SolutionName.sln /p:Configuration=Release /p:Platform=\"Any CPU\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"

			}
		}
		stage ('Deploy')
		{
			steps
			{
				echo ### Deploy step ###
			}
		}
	}
}