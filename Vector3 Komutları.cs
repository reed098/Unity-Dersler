
        float mesafe =  Vector3.Distance(transform.position, target.transform.position);
        //İki vector arasındaki mesafeyi float olarak verir bize.
        if(Vector3.Distance(transform.position,target.transform.position) > 15)
        {
            Debug.Log("başarılı");
        }

        transform.position =  Vector3.Lerp(transform.position, target.transform.position, 2f * Time.deltaTime);
        //başlangıç pozisyonundan bitiş pozisyonuna yumuşak olarak gider. Hızı sabit değildir.

        transform.position =  Vector3.MoveTowards(transform.position,target.transform.position,2*Time.deltaTime);
        //başlangıç pozsiyonundan bitiş pozisyonuna hızı sabit olarak gider. Hızı her zaman sabittir.

        transform.position =  Vector3.Slerp(transform.position,target.transform.position,2*Time.deltaTime);
        //başlangıç pozisyonundan bitiş pozisyonuna yumuşak ve dairesel olarak gider. Lerp'in aynısıdır fakat yarım daire şeklinde hedefe gider.

        Vector3 vec =  Vector3.Max(transform.position, target.transform.position);
        //İki vector arasındaki en büyük değeri dönderir bize.

        Vector3 vec2 =  Vector3.Min(transform.position, target.transform.position);
        //İki vector arasındaki en küçük değeri dönderir bize.

        Vector3.Scale(transform.position, target.transform.position);
        //İki vectorün çarpımını dönderir bize.

        float vec3 =  Vector3.Angle(transform.position,target.transform.position);
        //İki vector arasındaki derece farkını dönderir bize.

        transform.parent = target.transform;
        //target bizim parentimiz oluyor.

        transform.LookAt(target.transform);
        //z yönümüz her zaman hedef transformuna dönük oluyor.
