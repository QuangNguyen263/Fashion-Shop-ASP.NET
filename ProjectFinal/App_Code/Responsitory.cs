using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Responsitory
/// </summary>
public class Responsitory
{
    public Responsitory()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public int getUser(string name, string pass)
    {
        LQDataContext dm = new LQDataContext();
        var q = (from a in dm.user_names
                 where a.user_name1 == name
                 where a.password == pass
                 where a.id_usrole == 1
                 select a).SingleOrDefault();
        if (q == null)
        {
            return -1;
        }
        else
        {
            return q.id_user;
        }
    }
    public user_name getUserbyID(int id)
    {
        LQDataContext dm = new LQDataContext();
        var q = (from a in dm.user_names
                 where a.id_user == id
                 select a).SingleOrDefault();
        return q;
    }
    public void UpdateUser(user_name un)
    {
        try
        {
            LQDataContext ctxx = new LQDataContext();
            var q = ctxx.user_names.Where(d => d.id_user == un.id_user).SingleOrDefault();
            q.user_name1 = un.user_name1;
            q.usFulname = un.usFulname;
            q.usImg = un.usImg;
            q.usAge = un.usAge;
            q.email = un.email;
            ctxx.SubmitChanges();
        }
        catch (Exception ex)
        {

        }
    }
    public void UpdateUserPass(user_name un)
    {
        try
        {
            LQDataContext ctxx = new LQDataContext();
            var q = ctxx.user_names.Where(d => d.id_user == un.id_user).SingleOrDefault();
            q.password = un.password;
            ctxx.SubmitChanges();
        }
        catch (Exception ex)
        {

        }
    }
    //all about category
    public List<cat> getAllCate()
    {
        LQDataContext ctx = new LQDataContext();
        return ctx.cats.ToList();
    }
    public cat getCate(int id)
    {
        LQDataContext dm = new LQDataContext();
        var q = (from a in dm.cats
                 where a.id_cat == id
                 select a).SingleOrDefault();
        return q;
    }
    public bool AddCate(cat catss)
    {

        LQDataContext ctxs = new LQDataContext();
        ctxs.cats.InsertOnSubmit(catss);
        ctxs.SubmitChanges();
        return true;
    }
    public void UpdateCate(cat ca)
    {
        try
        {
            LQDataContext ctxx = new LQDataContext();
            var q = ctxx.cats.Where(d => d.id_cat == ca.id_cat).SingleOrDefault();
            q.cat_name = ca.cat_name;
            ctxx.SubmitChanges();
        }
        catch (Exception ex)
        {

        }
    }
    public bool DeleteCate(int id)
    {
        try
        {
            LQDataContext dm = new LQDataContext();
            var q = (from a in dm.cats
                     where a.id_cat == id
                     select a).SingleOrDefault();
            dm.cats.DeleteOnSubmit(q);
            dm.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }

    }

    //all about pro duct
    public List<prod> getAllProduct()
    {
        LQDataContext ctx = new LQDataContext();
        return ctx.prods.ToList();
    }
    public List<prod> getTopProduct(int top)
    {
        LQDataContext ctx = new LQDataContext();
        var list = (from t in ctx.prods
                    orderby t.pro_price
                    select t).Take(top);
        return list.ToList();
    }
    public List<prod> getCateProduct(int cate)
    {
        LQDataContext ctx = new LQDataContext();
        var list = (from t in ctx.prods
                    where t.id_cat == cate
                    select t);
        return list.ToList();
    }
    public bool checkalprod(string name)
    {
        LQDataContext dm = new LQDataContext();
        var q = (from a in dm.prods
                 where a.pro_name == name
                 select a).SingleOrDefault();
        if (q == null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public prod getProduct(int id)
    {
        LQDataContext dm = new LQDataContext();
        var q = (from a in dm.prods
                 where a.id_pro == id
                 select a).SingleOrDefault();
        return q;
    }
    public List<mainIMGPro> getMainProduct()
    {
        LQDataContext dm = new LQDataContext();
        var q = (from a in dm.prods
                 join c in dm.img_prods
                 on a.id_pro equals c.id_prod
                 where c.stt_img == 1
                 select (new mainIMGPro
                 {
                     idCatMPro = a.id_cat,
                     idMPro = a.id_pro,
                     nameMPro = a.pro_name,
                     priceMPro = float.Parse(a.pro_price + ""),
                     imgMPro = c.img_url
                 }

                 )
                 );
        return q.ToList();
    }
    public List<mainIMGPro> getMainCateProduct(int cate)
    {
        LQDataContext ctx = new LQDataContext();

        var q = (from a in ctx.prods
                 join c in ctx.img_prods
                 on a.id_pro equals c.id_prod
                 where a.id_cat == cate
                 where c.stt_img == 1

                 select (new mainIMGPro
                 {
                     idCatMPro = a.id_cat,
                     idMPro = a.id_pro,
                     nameMPro = a.pro_name,
                     priceMPro = float.Parse(a.pro_price + ""),
                     imgMPro = c.img_url
                 }

                 )
             );

        return q.ToList();
    }
    public List<mainIMGPro> getSearchProduct(string result)
    {
        LQDataContext ctx = new LQDataContext();

        var q = (from a in ctx.prods
                 join c in ctx.img_prods
                 on a.id_pro equals c.id_prod
                 where a.pro_name.Contains(result.Trim())
                 where c.stt_img == 1

                 select (new mainIMGPro
                 {
                     idCatMPro = a.id_cat,
                     idMPro = a.id_pro,
                     nameMPro = a.pro_name,
                     priceMPro = float.Parse(a.pro_price + ""),
                     imgMPro = c.img_url
                 }

                 )
             );

        return q.ToList();
    }
    public bool AddProduct(prod pr)
    {
        LQDataContext ctxs = new LQDataContext();
        ctxs.prods.InsertOnSubmit(pr);
        ctxs.SubmitChanges();
        return true;
    }
    public void UpdateProduct(prod pr)
    {
        try
        {
            LQDataContext ctxx = new LQDataContext();
            var q = ctxx.prods.Where(d => d.id_pro == pr.id_pro).SingleOrDefault();
            q.id_cat = pr.id_cat;
            q.pro_name = pr.pro_name;
            q.pro_price = pr.pro_price;
            ctxx.SubmitChanges();
        }
        catch (Exception ex)
        {

        }
    }
    public bool DeleteProduct(int id)
    {
        try
        {
            LQDataContext dm = new LQDataContext();
            var q = (from a in dm.prods
                     where a.id_pro == id
                     select a).SingleOrDefault();
            dm.prods.DeleteOnSubmit(q);
            dm.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }




    }
    //all about customer
    public List<cust> getAllCustomer()
    {
        LQDataContext ctx = new LQDataContext();
        return ctx.custs.ToList();
    }
    public bool AddCustomer(cust ca)
    {
        LQDataContext ctxs = new LQDataContext();
        ctxs.custs.InsertOnSubmit(ca);
        ctxs.SubmitChanges();
        return true;
    }
    public void UpdateCustomer(cust ca)
    {
        try
        {
            LQDataContext ctxx = new LQDataContext();
            var q = ctxx.custs.Where(d => d.id_cus == ca.id_cus).SingleOrDefault();
            q.cus_name = ca.cus_name;
            q.email = ca.email;
            ctxx.SubmitChanges();
        }
        catch (Exception ex)
        {

        }
    }
    public bool DeleteCustomer(int id)
    {
        try
        {
            LQDataContext dm = new LQDataContext();
            var q = (from a in dm.custs
                     where a.id_cus == id
                     select a).SingleOrDefault();
            dm.custs.DeleteOnSubmit(q);
            dm.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }

    }
    public int checkCus(string name, string email)
    {
        LQDataContext dm = new LQDataContext();
        var q = (from a in dm.custs
                 where a.cus_name == name
                 where a.email == email
                 select a).SingleOrDefault();
        if (q == null)
        {
            return -1;
        }
        else
        {
            return q.id_cus;
        }
    }
    public cust getCusbyID(int id)
    {
        LQDataContext dm = new LQDataContext();
        var q = (from a in dm.custs
                 where a.id_cus == id
                 select a).SingleOrDefault();
        return q;
    }

    //all about cart
    public List<cart> getAllCart()
    {
        LQDataContext ctx = new LQDataContext();
        return ctx.carts.ToList();
    }
    public List<cart> getCustomerCart(int idcus)
    {
        LQDataContext ctx = new LQDataContext();
        var list = (from t in ctx.carts
                    where t.id_cus == idcus
                    select t);
        return list.ToList();
    }
    public bool checkalcate(string name)
    {
        LQDataContext dm = new LQDataContext();
        var q = (from a in dm.cats
                 where a.cat_name == name
                 select a).SingleOrDefault();
        if (q == null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool AddCart(cart ca)
    {
        LQDataContext ctxs = new LQDataContext();
        ctxs.carts.InsertOnSubmit(ca);
        ctxs.SubmitChanges();
        return true;
    }
    public void UpdateCate(cart ca)
    {
        try
        {
            LQDataContext ctxx = new LQDataContext();
            var q = ctxx.carts.Where(d => d.id_cart == ca.id_cart).SingleOrDefault();
            q.time_cart = ca.time_cart;
            ctxx.SubmitChanges();
        }
        catch (Exception ex)
        {

        }
    }
    public bool DeleteCart(int id)
    {
        try
        {
            LQDataContext dm = new LQDataContext();
            var q = (from a in dm.carts
                     where a.id_cart == id
                     select a).SingleOrDefault();
            dm.carts.DeleteOnSubmit(q);
            dm.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }

    }



    //all about detail cart
    public List<detail_cart> getAlldtCart()
    {
        LQDataContext ctx = new LQDataContext();
        return ctx.detail_carts.ToList();
    }
    public List<detail_cart> getDetailCartID(int idcart)
    {
        LQDataContext ctx = new LQDataContext();
        var list = (from t in ctx.detail_carts
                    where t.id_cart == idcart
                    select t);
        return list.ToList();
    }
    public bool AdddtCart(detail_cart ca)
    {
        LQDataContext ctxs = new LQDataContext();
        ctxs.detail_carts.InsertOnSubmit(ca);
        ctxs.SubmitChanges();
        return true;
    }

    public detail_cart getdtCart(int id_Cart)
    {
        LQDataContext dm = new LQDataContext();
        var q = (from a in dm.detail_carts
                 where a.id_cart == id_Cart
                 select a).SingleOrDefault();
        return q;
    }
    public bool checkdtCart(int id_dtCart, int id_proz)
    {
        LQDataContext dm = new LQDataContext();
        var q = (from a in dm.detail_carts
                 where a.id_dtcart == id_dtCart
                 where a.id_pro == id_proz
                 select a).SingleOrDefault();
        if (q != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void updatedtCart(detail_cart dtc)
    {
        LQDataContext ctxx = new LQDataContext();
        var q = ctxx.detail_carts.Where(d => d.id_dtcart == dtc.id_dtcart).SingleOrDefault();
        q.id_pro = dtc.id_pro;
        q.quanlity = dtc.quanlity;
        ctxx.SubmitChanges();
    }
    public bool DeletedtCart(int id_dtCart)
    {
        try
        {
            LQDataContext dm = new LQDataContext();
            var q = (from a in dm.detail_carts
                     where a.id_dtcart == id_dtCart
                     select a).SingleOrDefault();
            dm.detail_carts.DeleteOnSubmit(q);
            dm.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }

    }

    //all about image
    public List<img_prod> getAllimgpro()
    {
        LQDataContext ctx = new LQDataContext();
        return ctx.img_prods.ToList();
    }
    public List<img_prod> getProdImage(int idprod)
    {
        LQDataContext ctx = new LQDataContext();
        var list = (from t in ctx.img_prods
                    where t.id_prod == idprod
                    select t);
        return list.ToList();
    }
    public img_prod getImage(int id)
    {
        LQDataContext ctx = new LQDataContext();
        var n = (from t in ctx.img_prods
                 where t.id_img == id
                 select t).SingleOrDefault();
        return n;
    }
    public bool AddimgProd(img_prod imp)
    {
        LQDataContext ctxs = new LQDataContext();
        ctxs.img_prods.InsertOnSubmit(imp);
        ctxs.SubmitChanges();
        return true;
    }
    public img_prod getMainimg(int idprod)
    {
        LQDataContext ctx = new LQDataContext();
        var azz = (from t in ctx.img_prods
                   where t.id_prod == idprod
                   where t.stt_img == 1
                   select t).SingleOrDefault();
        return azz;
    }
    public void SetSttImage(img_prod imp, int mstt)
    {
        try
        {
            LQDataContext ctxx = new LQDataContext();
            var q = ctxx.img_prods.Where(d => d.id_img == imp.id_img).SingleOrDefault();
            q.stt_img = mstt;
            ctxx.SubmitChanges();
        }
        catch (Exception ex)
        {

        }
    }
    public void UpdateimgProd(img_prod imp)
    {
        try
        {
            LQDataContext ctxx = new LQDataContext();
            var q = ctxx.img_prods.Where(d => d.id_img == imp.id_img).SingleOrDefault();
            q.img_url = imp.img_url;
            ctxx.SubmitChanges();
        }
        catch (Exception ex)
        {

        }
    }
    public bool DeleteImgProd(int id)
    {
        try
        {
            LQDataContext dm = new LQDataContext();
            var q = (from a in dm.img_prods
                     where a.id_img == id
                     select a).SingleOrDefault();
            dm.img_prods.DeleteOnSubmit(q);
            dm.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }

    }

}
