﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class ObjectPooler : MonoBehaviour
    {
        public static ObjectPooler current;

        public GameObject pooledObject;
        public int amountPooled = 20;

        public bool willGrow;

        public List<GameObject> pooledObjects;

        void Awake()
        {
            current = this;
        }

        void Start()
        {
            pooledObjects = new List<GameObject>();
            for (int i = 0; i < amountPooled; i++)
            {
                GameObject obj = (GameObject)Instantiate(pooledObject);
                obj.SetActive(false);
                pooledObjects.Add(obj);
            }
        }


        public GameObject GetPooledObject()
        {
            for (int i = 0; i < pooledObjects.Count; i++)
            {
                if (!pooledObjects[i].activeInHierarchy)
                {
                    return pooledObjects[i];
                }
            }
            if (willGrow)
            {
                GameObject obj = (GameObject)Instantiate(pooledObject);
                pooledObjects.Add(obj);
                return obj;
            }
            return null;
        }
    }

