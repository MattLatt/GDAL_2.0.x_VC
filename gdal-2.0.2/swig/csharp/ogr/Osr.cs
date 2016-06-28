/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace OSGeo.OGR {

using System;
using System.Runtime.InteropServices;

public class Osr {

  internal class OsrObject : IDisposable {
	public virtual void Dispose() {
      
    }
  }
  internal static OsrObject theOsrObject = new OsrObject();
  protected static object ThisOwn_true() { return null; }
  protected static object ThisOwn_false() { return theOsrObject; }

  public static void UseExceptions() {
    OsrPINVOKE.UseExceptions();
  }

  public static void DontUseExceptions() {
    OsrPINVOKE.DontUseExceptions();
  }


  internal static byte[] StringToUtf8Bytes(string str)
  {
    if (str == null)
      return null;
    
    int bytecount = System.Text.Encoding.UTF8.GetMaxByteCount(str.Length);
    byte[] bytes = new byte[bytecount + 1];
    System.Text.Encoding.UTF8.GetBytes(str, 0, str.Length, bytes, 0);
    return bytes;
  }
  
  internal static string Utf8BytesToString(IntPtr pNativeData)
  {
    if (pNativeData == IntPtr.Zero)
        return null;
        
    int length = Marshal.PtrToStringAnsi(pNativeData).Length;
    byte[] strbuf = new byte[length];  
    Marshal.Copy(pNativeData, strbuf, 0, length); 
    return System.Text.Encoding.UTF8.GetString(strbuf);
  }

  internal static void StringListDestroy(IntPtr buffer_ptr) {
    OsrPINVOKE.StringListDestroy(buffer_ptr);
    if (OsrPINVOKE.SWIGPendingException.Pending) throw OsrPINVOKE.SWIGPendingException.Retrieve();
  }

public delegate void GDALErrorHandlerDelegate(int eclass, int code, IntPtr msg);
public delegate int GDALProgressFuncDelegate(double Complete, IntPtr Message, IntPtr Data);
  public static int GetWellKnownGeogCSAsWKT(string name, out string argout) {
    int ret = OsrPINVOKE.GetWellKnownGeogCSAsWKT(name, out argout);
    if (OsrPINVOKE.SWIGPendingException.Pending) throw OsrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int GetUserInputAsWKT(string name, out string argout) {
    int ret = OsrPINVOKE.GetUserInputAsWKT(name, out argout);
    if (OsrPINVOKE.SWIGPendingException.Pending) throw OsrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string[] GetProjectionMethods() {
        /* %typemap(csout) char** CSL */
        IntPtr cPtr = OsrPINVOKE.GetProjectionMethods();
        IntPtr objPtr;
        int count = 0;
        if (cPtr != IntPtr.Zero) {
            while (Marshal.ReadIntPtr(cPtr, count*IntPtr.Size) != IntPtr.Zero)
                ++count;
        }
        string[] ret = new string[count];
        if (count > 0) {       
	        for(int cx = 0; cx < count; cx++) {
                objPtr = System.Runtime.InteropServices.Marshal.ReadIntPtr(cPtr, cx * System.Runtime.InteropServices.Marshal.SizeOf(typeof(IntPtr)));
                ret[cx]= (objPtr == IntPtr.Zero) ? null : System.Runtime.InteropServices.Marshal.PtrToStringAnsi(objPtr);
            }
        }
        if (cPtr != IntPtr.Zero)
            OsrPINVOKE.StringListDestroy(cPtr);
        
    if (OsrPINVOKE.SWIGPendingException.Pending) throw OsrPINVOKE.SWIGPendingException.Retrieve();
        return ret;
}

  public static string[] GetProjectionMethodParameterList(string method, out string username) {
        /* %typemap(csout) char** CSL */
        IntPtr cPtr = OsrPINVOKE.GetProjectionMethodParameterList(method, out username);
        IntPtr objPtr;
        int count = 0;
        if (cPtr != IntPtr.Zero) {
            while (Marshal.ReadIntPtr(cPtr, count*IntPtr.Size) != IntPtr.Zero)
                ++count;
        }
        string[] ret = new string[count];
        if (count > 0) {       
	        for(int cx = 0; cx < count; cx++) {
                objPtr = System.Runtime.InteropServices.Marshal.ReadIntPtr(cPtr, cx * System.Runtime.InteropServices.Marshal.SizeOf(typeof(IntPtr)));
                ret[cx]= (objPtr == IntPtr.Zero) ? null : System.Runtime.InteropServices.Marshal.PtrToStringAnsi(objPtr);
            }
        }
        if (cPtr != IntPtr.Zero)
            OsrPINVOKE.StringListDestroy(cPtr);
        
    if (OsrPINVOKE.SWIGPendingException.Pending) throw OsrPINVOKE.SWIGPendingException.Retrieve();
        return ret;
}

  public static void GetProjectionMethodParamInfo(string method, string param, out string usrname, out string type, ref double defaultval) {
    OsrPINVOKE.GetProjectionMethodParamInfo(method, param, out usrname, out type, ref defaultval);
    if (OsrPINVOKE.SWIGPendingException.Pending) throw OsrPINVOKE.SWIGPendingException.Retrieve();
  }

  public static CoordinateTransformation CreateCoordinateTransformation(SpatialReference src, SpatialReference dst) {
    IntPtr cPtr = OsrPINVOKE.CreateCoordinateTransformation(SpatialReference.getCPtr(src), SpatialReference.getCPtr(dst));
    CoordinateTransformation ret = (cPtr == IntPtr.Zero) ? null : new CoordinateTransformation(cPtr, true, ThisOwn_true());
    if (OsrPINVOKE.SWIGPendingException.Pending) throw OsrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public const string SRS_WKT_WGS84 = "GEOGCS[\"WGS 84\",DATUM[\"WGS_1984\",SPHEROID[\"WGS 84\",6378137,298.257223563,AUTHORITY[\"EPSG\",\"7030\"]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[\"EPSG\",\"6326\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.0174532925199433,AUTHORITY[\"EPSG\",\"9108\"]],AUTHORITY[\"EPSG\",\"4326\"]]";
  public const string SRS_PT_ALBERS_CONIC_EQUAL_AREA = "Albers_Conic_Equal_Area";
  public const string SRS_PT_AZIMUTHAL_EQUIDISTANT = "Azimuthal_Equidistant";
  public const string SRS_PT_CASSINI_SOLDNER = "Cassini_Soldner";
  public const string SRS_PT_CYLINDRICAL_EQUAL_AREA = "Cylindrical_Equal_Area";
  public const string SRS_PT_BONNE = "Bonne";
  public const string SRS_PT_ECKERT_I = "Eckert_I";
  public const string SRS_PT_ECKERT_II = "Eckert_II";
  public const string SRS_PT_ECKERT_III = "Eckert_III";
  public const string SRS_PT_ECKERT_IV = "Eckert_IV";
  public const string SRS_PT_ECKERT_V = "Eckert_V";
  public const string SRS_PT_ECKERT_VI = "Eckert_VI";
  public const string SRS_PT_EQUIDISTANT_CONIC = "Equidistant_Conic";
  public const string SRS_PT_EQUIRECTANGULAR = "Equirectangular";
  public const string SRS_PT_GALL_STEREOGRAPHIC = "Gall_Stereographic";
  public const string SRS_PT_GAUSSSCHREIBERTMERCATOR = "Gauss_Schreiber_Transverse_Mercator";
  public const string SRS_PT_GEOSTATIONARY_SATELLITE = "Geostationary_Satellite";
  public const string SRS_PT_GOODE_HOMOLOSINE = "Goode_Homolosine";
  public const string SRS_PT_IGH = "Interrupted_Goode_Homolosine";
  public const string SRS_PT_GNOMONIC = "Gnomonic";
  public const string SRS_PT_HOTINE_OBLIQUE_MERCATOR_AZIMUTH_CENTER = "Hotine_Oblique_Mercator_Azimuth_Center";
  public const string SRS_PT_HOTINE_OBLIQUE_MERCATOR = "Hotine_Oblique_Mercator";
  public const string SRS_PT_HOTINE_OBLIQUE_MERCATOR_TWO_POINT_NATURAL_ORIGIN = "Hotine_Oblique_Mercator_Two_Point_Natural_Origin";
  public const string SRS_PT_LABORDE_OBLIQUE_MERCATOR = "Laborde_Oblique_Mercator";
  public const string SRS_PT_LAMBERT_CONFORMAL_CONIC_1SP = "Lambert_Conformal_Conic_1SP";
  public const string SRS_PT_LAMBERT_CONFORMAL_CONIC_2SP = "Lambert_Conformal_Conic_2SP";
  public const string SRS_PT_LAMBERT_CONFORMAL_CONIC_2SP_BELGIUM = "Lambert_Conformal_Conic_2SP_Belgium";
  public const string SRS_PT_LAMBERT_AZIMUTHAL_EQUAL_AREA = "Lambert_Azimuthal_Equal_Area";
  public const string SRS_PT_MERCATOR_1SP = "Mercator_1SP";
  public const string SRS_PT_MERCATOR_2SP = "Mercator_2SP";
  public const string SRS_PT_MERCATOR_AUXILIARY_SPHERE = "Mercator_Auxiliary_Sphere";
  public const string SRS_PT_MILLER_CYLINDRICAL = "Miller_Cylindrical";
  public const string SRS_PT_MOLLWEIDE = "Mollweide";
  public const string SRS_PT_NEW_ZEALAND_MAP_GRID = "New_Zealand_Map_Grid";
  public const string SRS_PT_OBLIQUE_STEREOGRAPHIC = "Oblique_Stereographic";
  public const string SRS_PT_ORTHOGRAPHIC = "Orthographic";
  public const string SRS_PT_POLAR_STEREOGRAPHIC = "Polar_Stereographic";
  public const string SRS_PT_POLYCONIC = "Polyconic";
  public const string SRS_PT_ROBINSON = "Robinson";
  public const string SRS_PT_SINUSOIDAL = "Sinusoidal";
  public const string SRS_PT_STEREOGRAPHIC = "Stereographic";
  public const string SRS_PT_SWISS_OBLIQUE_CYLINDRICAL = "Swiss_Oblique_Cylindrical";
  public const string SRS_PT_TRANSVERSE_MERCATOR = "Transverse_Mercator";
  public const string SRS_PT_TRANSVERSE_MERCATOR_SOUTH_ORIENTED = "Transverse_Mercator_South_Orientated";
  public const string SRS_PT_TRANSVERSE_MERCATOR_MI_21 = "Transverse_Mercator_MapInfo_21";
  public const string SRS_PT_TRANSVERSE_MERCATOR_MI_22 = "Transverse_Mercator_MapInfo_22";
  public const string SRS_PT_TRANSVERSE_MERCATOR_MI_23 = "Transverse_Mercator_MapInfo_23";
  public const string SRS_PT_TRANSVERSE_MERCATOR_MI_24 = "Transverse_Mercator_MapInfo_24";
  public const string SRS_PT_TRANSVERSE_MERCATOR_MI_25 = "Transverse_Mercator_MapInfo_25";
  public const string SRS_PT_TUNISIA_MINING_GRID = "Tunisia_Mining_Grid";
  public const string SRS_PT_TWO_POINT_EQUIDISTANT = "Two_Point_Equidistant";
  public const string SRS_PT_VANDERGRINTEN = "VanDerGrinten";
  public const string SRS_PT_KROVAK = "Krovak";
  public const string SRS_PT_IMW_POLYCONIC = "International_Map_of_the_World_Polyconic";
  public const string SRS_PT_WAGNER_I = "Wagner_I";
  public const string SRS_PT_WAGNER_II = "Wagner_II";
  public const string SRS_PT_WAGNER_III = "Wagner_III";
  public const string SRS_PT_WAGNER_IV = "Wagner_IV";
  public const string SRS_PT_WAGNER_V = "Wagner_V";
  public const string SRS_PT_WAGNER_VI = "Wagner_VI";
  public const string SRS_PT_WAGNER_VII = "Wagner_VII";
  public const string SRS_PT_QSC = "Quadrilateralized_Spherical_Cube";
  public const string SRS_PT_AITOFF = "Aitoff";
  public const string SRS_PT_WINKEL_I = "Winkel_I";
  public const string SRS_PT_WINKEL_II = "Winkel_II";
  public const string SRS_PT_WINKEL_TRIPEL = "Winkel_Tripel";
  public const string SRS_PT_CRASTER_PARABOLIC = "Craster_Parabolic";
  public const string SRS_PT_LOXIMUTHAL = "Loximuthal";
  public const string SRS_PT_QUARTIC_AUTHALIC = "Quartic_Authalic";
  public const string SRS_PP_CENTRAL_MERIDIAN = "central_meridian";
  public const string SRS_PP_SCALE_FACTOR = "scale_factor";
  public const string SRS_PP_STANDARD_PARALLEL_1 = "standard_parallel_1";
  public const string SRS_PP_STANDARD_PARALLEL_2 = "standard_parallel_2";
  public const string SRS_PP_PSEUDO_STD_PARALLEL_1 = "pseudo_standard_parallel_1";
  public const string SRS_PP_LONGITUDE_OF_CENTER = "longitude_of_center";
  public const string SRS_PP_LATITUDE_OF_CENTER = "latitude_of_center";
  public const string SRS_PP_LONGITUDE_OF_ORIGIN = "longitude_of_origin";
  public const string SRS_PP_LATITUDE_OF_ORIGIN = "latitude_of_origin";
  public const string SRS_PP_FALSE_EASTING = "false_easting";
  public const string SRS_PP_FALSE_NORTHING = "false_northing";
  public const string SRS_PP_AZIMUTH = "azimuth";
  public const string SRS_PP_LONGITUDE_OF_POINT_1 = "longitude_of_point_1";
  public const string SRS_PP_LATITUDE_OF_POINT_1 = "latitude_of_point_1";
  public const string SRS_PP_LONGITUDE_OF_POINT_2 = "longitude_of_point_2";
  public const string SRS_PP_LATITUDE_OF_POINT_2 = "latitude_of_point_2";
  public const string SRS_PP_LONGITUDE_OF_POINT_3 = "longitude_of_point_3";
  public const string SRS_PP_LATITUDE_OF_POINT_3 = "latitude_of_point_3";
  public const string SRS_PP_RECTIFIED_GRID_ANGLE = "rectified_grid_angle";
  public const string SRS_PP_LANDSAT_NUMBER = "landsat_number";
  public const string SRS_PP_PATH_NUMBER = "path_number";
  public const string SRS_PP_PERSPECTIVE_POINT_HEIGHT = "perspective_point_height";
  public const string SRS_PP_SATELLITE_HEIGHT = "satellite_height";
  public const string SRS_PP_FIPSZONE = "fipszone";
  public const string SRS_PP_ZONE = "zone";
  public const string SRS_PP_LATITUDE_OF_1ST_POINT = "Latitude_Of_1st_Point";
  public const string SRS_PP_LONGITUDE_OF_1ST_POINT = "Longitude_Of_1st_Point";
  public const string SRS_PP_LATITUDE_OF_2ND_POINT = "Latitude_Of_2nd_Point";
  public const string SRS_PP_LONGITUDE_OF_2ND_POINT = "Longitude_Of_2nd_Point";
  public const string SRS_UL_METER = "Meter";
  public const string SRS_UL_FOOT = "Foot (International)";
  public const string SRS_UL_FOOT_CONV = "0.3048";
  public const string SRS_UL_US_FOOT = "Foot_US";
  public const string SRS_UL_US_FOOT_CONV = "0.3048006096012192";
  public const string SRS_UL_NAUTICAL_MILE = "Nautical Mile";
  public const string SRS_UL_NAUTICAL_MILE_CONV = "1852.0";
  public const string SRS_UL_LINK = "Link";
  public const string SRS_UL_LINK_CONV = "0.20116684023368047";
  public const string SRS_UL_CHAIN = "Chain";
  public const string SRS_UL_CHAIN_CONV = "20.116684023368047";
  public const string SRS_UL_ROD = "Rod";
  public const string SRS_UL_ROD_CONV = "5.02921005842012";
  public const string SRS_UL_LINK_Clarke = "Link_Clarke";
  public const string SRS_UL_LINK_Clarke_CONV = "0.2011661949";
  public const string SRS_UL_KILOMETER = "Kilometer";
  public const string SRS_UL_KILOMETER_CONV = "1000.";
  public const string SRS_UL_DECIMETER = "Decimeter";
  public const string SRS_UL_DECIMETER_CONV = "0.1";
  public const string SRS_UL_CENTIMETER = "Centimeter";
  public const string SRS_UL_CENTIMETER_CONV = "0.01";
  public const string SRS_UL_MILLIMETER = "Millimeter";
  public const string SRS_UL_MILLIMETER_CONV = "0.001";
  public const string SRS_UL_INTL_NAUT_MILE = "Nautical_Mile_International";
  public const string SRS_UL_INTL_NAUT_MILE_CONV = "1852.0";
  public const string SRS_UL_INTL_INCH = "Inch_International";
  public const string SRS_UL_INTL_INCH_CONV = "0.0254";
  public const string SRS_UL_INTL_FOOT = "Foot_International";
  public const string SRS_UL_INTL_FOOT_CONV = "0.3048";
  public const string SRS_UL_INTL_YARD = "Yard_International";
  public const string SRS_UL_INTL_YARD_CONV = "0.9144";
  public const string SRS_UL_INTL_STAT_MILE = "Statute_Mile_International";
  public const string SRS_UL_INTL_STAT_MILE_CONV = "1609.344";
  public const string SRS_UL_INTL_FATHOM = "Fathom_International";
  public const string SRS_UL_INTL_FATHOM_CONV = "1.8288";
  public const string SRS_UL_INTL_CHAIN = "Chain_International";
  public const string SRS_UL_INTL_CHAIN_CONV = "20.1168";
  public const string SRS_UL_INTL_LINK = "Link_International";
  public const string SRS_UL_INTL_LINK_CONV = "0.201168";
  public const string SRS_UL_US_INCH = "Inch_US_Surveyor";
  public const string SRS_UL_US_INCH_CONV = "0.025400050800101603";
  public const string SRS_UL_US_YARD = "Yard_US_Surveyor";
  public const string SRS_UL_US_YARD_CONV = "0.914401828803658";
  public const string SRS_UL_US_CHAIN = "Chain_US_Surveyor";
  public const string SRS_UL_US_CHAIN_CONV = "20.11684023368047";
  public const string SRS_UL_US_STAT_MILE = "Statute_Mile_US_Surveyor";
  public const string SRS_UL_US_STAT_MILE_CONV = "1609.347218694437";
  public const string SRS_UL_INDIAN_YARD = "Yard_Indian";
  public const string SRS_UL_INDIAN_YARD_CONV = "0.91439523";
  public const string SRS_UL_INDIAN_FOOT = "Foot_Indian";
  public const string SRS_UL_INDIAN_FOOT_CONV = "0.30479841";
  public const string SRS_UL_INDIAN_CHAIN = "Chain_Indian";
  public const string SRS_UL_INDIAN_CHAIN_CONV = "20.11669506";
  public const string SRS_UA_DEGREE = "degree";
  public const string SRS_UA_DEGREE_CONV = "0.0174532925199433";
  public const string SRS_UA_RADIAN = "radian";
  public const string SRS_PM_GREENWICH = "Greenwich";
  public const string SRS_DN_NAD27 = "North_American_Datum_1927";
  public const string SRS_DN_NAD83 = "North_American_Datum_1983";
  public const string SRS_DN_WGS72 = "WGS_1972";
  public const string SRS_DN_WGS84 = "WGS_1984";
  public const double SRS_WGS84_SEMIMAJOR = 6378137.0;
  public const double SRS_WGS84_INVFLATTENING = 298.257223563;
}

}
