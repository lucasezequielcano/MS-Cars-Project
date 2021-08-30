using System;

namespace MS_Cars_Project
{
    public class Car
    {
        ///variables
        string model;
        byte doorsQuantity;
        string color;
        string transmission;
        static int localId;
        int productId;

        #region "GET/SET"
        public int getLocalId()
        {
            return localId;
        }
        public int getProductId()
        {
            return productId;
        }

        public void setProductId(int productId)
        {
            this.productId = productId;
        }

        public string getModel()
        {
            return model;
        }
        public void setModel(string model)
        {
            this.model = model;
        }
        public string getColor()
        {
            return color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public string getTransmission()
        {
            return transmission;
        }
        public void setTransmission(string transmission)
        {
            this.transmission = transmission;
        }
        public byte getDoorsQuantity(){
            return doorsQuantity; 
        }
        public void setDoorsQuantity(byte doorsQuantity){
            this.doorsQuantity=doorsQuantity; 
        }

        #endregion
        public void newID()
        {
            this.productId = localId;
            localId += 1;
        }
    }
}