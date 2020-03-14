pipeline {
  agent any
  stages {
    stage('GIT Checkout') {
      steps {
        git(branch: 'dev', url: 'https://github.com/Advanced-Alliance/The-Adventure.git', changelog: true)
        echo 'Git stage complete'
      }
    }

  }
}