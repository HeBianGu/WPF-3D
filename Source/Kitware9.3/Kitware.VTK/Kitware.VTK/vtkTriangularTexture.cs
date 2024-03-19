using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTriangularTexture
	/// </summary>
	/// <remarks>
	///    generate 2D triangular texture map
	///
	/// vtkTriangularTexture is a filter that generates a 2D texture map based on
	/// the paper "Opacity-modulating Triangular Textures for Irregular Surfaces,"
	/// by Penny Rheingans, IEEE Visualization '96, pp. 219-225.
	/// The textures assume texture coordinates of (0,0), (1.0) and
	/// (.5, sqrt(3)/2). The sequence of texture values is the same along each
	/// edge of the triangular texture map. So, the assignment order of texture
	/// coordinates is arbitrary.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTriangularTCoords
	/// </seealso>
	// Token: 0x020003EB RID: 1003
	public class vtkTriangularTexture : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C031 RID: 49201 RVA: 0x0010BBE7 File Offset: 0x00109DE7
		static vtkTriangularTexture()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTriangularTexture.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTriangularTexture"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C032 RID: 49202 RVA: 0x0010BC0F File Offset: 0x00109E0F
		public vtkTriangularTexture(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C033 RID: 49203
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriangularTexture_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object with XSize and YSize = 64; the texture pattern =1
		/// (opaque at centroid); and the scale factor set to 1.0.
		/// </summary>
		// Token: 0x0600C034 RID: 49204 RVA: 0x0010BC20 File Offset: 0x00109E20
		public new static vtkTriangularTexture New()
		{
			vtkTriangularTexture result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTriangularTexture.vtkTriangularTexture_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTriangularTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate object with XSize and YSize = 64; the texture pattern =1
		/// (opaque at centroid); and the scale factor set to 1.0.
		/// </summary>
		// Token: 0x0600C035 RID: 49205 RVA: 0x0010BC74 File Offset: 0x00109E74
		public vtkTriangularTexture() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTriangularTexture.vtkTriangularTexture_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C036 RID: 49206 RVA: 0x0010BCB8 File Offset: 0x00109EB8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C037 RID: 49207
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTriangularTexture_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C038 RID: 49208 RVA: 0x0010BCC4 File Offset: 0x00109EC4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTriangularTexture.vtkTriangularTexture_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600C039 RID: 49209
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTriangularTexture_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C03A RID: 49210 RVA: 0x0010BCE4 File Offset: 0x00109EE4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTriangularTexture.vtkTriangularTexture_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600C03B RID: 49211
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTriangularTexture_GetScaleFactor_03(HandleRef pThis);

		/// <summary>
		/// Set a Scale Factor.
		/// </summary>
		// Token: 0x0600C03C RID: 49212 RVA: 0x0010BD00 File Offset: 0x00109F00
		public virtual double GetScaleFactor()
		{
			return vtkTriangularTexture.vtkTriangularTexture_GetScaleFactor_03(base.GetCppThis());
		}

		// Token: 0x0600C03D RID: 49213
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangularTexture_GetTexturePattern_04(HandleRef pThis);

		/// <summary>
		/// Set the texture pattern.
		/// 1 = opaque at centroid (default)
		/// 2 = opaque at vertices
		/// 3 = opaque in rings around vertices
		/// </summary>
		// Token: 0x0600C03E RID: 49214 RVA: 0x0010BD20 File Offset: 0x00109F20
		public virtual int GetTexturePattern()
		{
			return vtkTriangularTexture.vtkTriangularTexture_GetTexturePattern_04(base.GetCppThis());
		}

		// Token: 0x0600C03F RID: 49215
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangularTexture_GetTexturePatternMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Set the texture pattern.
		/// 1 = opaque at centroid (default)
		/// 2 = opaque at vertices
		/// 3 = opaque in rings around vertices
		/// </summary>
		// Token: 0x0600C040 RID: 49216 RVA: 0x0010BD40 File Offset: 0x00109F40
		public virtual int GetTexturePatternMaxValue()
		{
			return vtkTriangularTexture.vtkTriangularTexture_GetTexturePatternMaxValue_05(base.GetCppThis());
		}

		// Token: 0x0600C041 RID: 49217
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangularTexture_GetTexturePatternMinValue_06(HandleRef pThis);

		/// <summary>
		/// Set the texture pattern.
		/// 1 = opaque at centroid (default)
		/// 2 = opaque at vertices
		/// 3 = opaque in rings around vertices
		/// </summary>
		// Token: 0x0600C042 RID: 49218 RVA: 0x0010BD60 File Offset: 0x00109F60
		public virtual int GetTexturePatternMinValue()
		{
			return vtkTriangularTexture.vtkTriangularTexture_GetTexturePatternMinValue_06(base.GetCppThis());
		}

		// Token: 0x0600C043 RID: 49219
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangularTexture_GetXSize_07(HandleRef pThis);

		/// <summary>
		/// Set the X texture map dimension. Default is 64.
		/// </summary>
		// Token: 0x0600C044 RID: 49220 RVA: 0x0010BD80 File Offset: 0x00109F80
		public virtual int GetXSize()
		{
			return vtkTriangularTexture.vtkTriangularTexture_GetXSize_07(base.GetCppThis());
		}

		// Token: 0x0600C045 RID: 49221
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangularTexture_GetYSize_08(HandleRef pThis);

		/// <summary>
		/// Set the Y texture map dimension. Default is 64.
		/// </summary>
		// Token: 0x0600C046 RID: 49222 RVA: 0x0010BDA0 File Offset: 0x00109FA0
		public virtual int GetYSize()
		{
			return vtkTriangularTexture.vtkTriangularTexture_GetYSize_08(base.GetCppThis());
		}

		// Token: 0x0600C047 RID: 49223
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangularTexture_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C048 RID: 49224 RVA: 0x0010BDC0 File Offset: 0x00109FC0
		public override int IsA(string type)
		{
			return vtkTriangularTexture.vtkTriangularTexture_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0600C049 RID: 49225
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangularTexture_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C04A RID: 49226 RVA: 0x0010BDE0 File Offset: 0x00109FE0
		public new static int IsTypeOf(string type)
		{
			return vtkTriangularTexture.vtkTriangularTexture_IsTypeOf_10(type);
		}

		// Token: 0x0600C04B RID: 49227
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriangularTexture_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C04C RID: 49228 RVA: 0x0010BDFC File Offset: 0x00109FFC
		public new vtkTriangularTexture NewInstance()
		{
			vtkTriangularTexture result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTriangularTexture.vtkTriangularTexture_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTriangularTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C04D RID: 49229
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriangularTexture_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C04E RID: 49230 RVA: 0x0010BE58 File Offset: 0x0010A058
		public new static vtkTriangularTexture SafeDownCast(vtkObjectBase o)
		{
			vtkTriangularTexture vtkTriangularTexture = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTriangularTexture.vtkTriangularTexture_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTriangularTexture = (vtkTriangularTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTriangularTexture.Register(null);
				}
			}
			return vtkTriangularTexture;
		}

		// Token: 0x0600C04F RID: 49231
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriangularTexture_SetScaleFactor_14(HandleRef pThis, double _arg);

		/// <summary>
		/// Set a Scale Factor.
		/// </summary>
		// Token: 0x0600C050 RID: 49232 RVA: 0x0010BED7 File Offset: 0x0010A0D7
		public virtual void SetScaleFactor(double _arg)
		{
			vtkTriangularTexture.vtkTriangularTexture_SetScaleFactor_14(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C051 RID: 49233
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriangularTexture_SetTexturePattern_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the texture pattern.
		/// 1 = opaque at centroid (default)
		/// 2 = opaque at vertices
		/// 3 = opaque in rings around vertices
		/// </summary>
		// Token: 0x0600C052 RID: 49234 RVA: 0x0010BEE7 File Offset: 0x0010A0E7
		public virtual void SetTexturePattern(int _arg)
		{
			vtkTriangularTexture.vtkTriangularTexture_SetTexturePattern_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C053 RID: 49235
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriangularTexture_SetXSize_16(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the X texture map dimension. Default is 64.
		/// </summary>
		// Token: 0x0600C054 RID: 49236 RVA: 0x0010BEF7 File Offset: 0x0010A0F7
		public virtual void SetXSize(int _arg)
		{
			vtkTriangularTexture.vtkTriangularTexture_SetXSize_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C055 RID: 49237
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTriangularTexture_SetYSize_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the Y texture map dimension. Default is 64.
		/// </summary>
		// Token: 0x0600C056 RID: 49238 RVA: 0x0010BF07 File Offset: 0x0010A107
		public virtual void SetYSize(int _arg)
		{
			vtkTriangularTexture.vtkTriangularTexture_SetYSize_17(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E43 RID: 3651
		public new const string MRFullTypeName = "Kitware.VTK.vtkTriangularTexture";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E44 RID: 3652
		public new static readonly string MRClassNameKey = "class vtkTriangularTexture";
	}
}
