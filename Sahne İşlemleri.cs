//parantez içindeki adı yazılı sahneyi yükler
SceneManager.LoadScene("SampleScene");


//şu anki aktif sahneyi yükler
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

//bu sahneden sonraki sahneyi yükler
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


    
