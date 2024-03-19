using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkScalarsToTextureFilter
	/// </summary>
	/// <remarks>
	///    generate texture coordinates and a texture image based on a scalar field
	///
	/// This filter computes texture coordinates and a 2D texture image based on a polydata,
	/// a color transfer function and an array.
	/// The output port 0 will contain the input polydata with computed texture coordinates.
	/// The output port 1 will contain the texture.
	/// The computed texture coordinates is based on vtkTextureMapToPlane which computes them using
	/// 3D positions projected on the best fitting plane.
	/// </remarks>
	/// <seealso>
	///  vtkTextureMapToPlane vtkResampleToImage
	/// </seealso>
	// Token: 0x02000540 RID: 1344
	public class vtkScalarsToTextureFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600EF2F RID: 61231 RVA: 0x0014D853 File Offset: 0x0014BA53
		static vtkScalarsToTextureFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkScalarsToTextureFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkScalarsToTextureFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600EF30 RID: 61232 RVA: 0x0014D87B File Offset: 0x0014BA7B
		public vtkScalarsToTextureFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600EF31 RID: 61233
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarsToTextureFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EF32 RID: 61234 RVA: 0x0014D88C File Offset: 0x0014BA8C
		public new static vtkScalarsToTextureFilter New()
		{
			vtkScalarsToTextureFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarsToTextureFilter.vtkScalarsToTextureFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkScalarsToTextureFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EF33 RID: 61235 RVA: 0x0014D8E0 File Offset: 0x0014BAE0
		public vtkScalarsToTextureFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkScalarsToTextureFilter.vtkScalarsToTextureFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600EF34 RID: 61236 RVA: 0x0014D924 File Offset: 0x0014BB24
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600EF35 RID: 61237
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkScalarsToTextureFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EF36 RID: 61238 RVA: 0x0014D930 File Offset: 0x0014BB30
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkScalarsToTextureFilter.vtkScalarsToTextureFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600EF37 RID: 61239
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkScalarsToTextureFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EF38 RID: 61240 RVA: 0x0014D950 File Offset: 0x0014BB50
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkScalarsToTextureFilter.vtkScalarsToTextureFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600EF39 RID: 61241
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarsToTextureFilter_GetTextureDimensions_03(HandleRef pThis);

		/// <summary>
		/// Get/Set the width and height of the generated texture.
		/// Default is 128x128. The width and height must be greater than 1.
		/// </summary>
		// Token: 0x0600EF3A RID: 61242 RVA: 0x0014D96C File Offset: 0x0014BB6C
		public virtual int[] GetTextureDimensions()
		{
			IntPtr intPtr = vtkScalarsToTextureFilter.vtkScalarsToTextureFilter_GetTextureDimensions_03(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600EF3B RID: 61243
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToTextureFilter_GetTextureDimensions_04(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Get/Set the width and height of the generated texture.
		/// Default is 128x128. The width and height must be greater than 1.
		/// </summary>
		// Token: 0x0600EF3C RID: 61244 RVA: 0x0014D9B4 File Offset: 0x0014BBB4
		public virtual void GetTextureDimensions(ref int _arg1, ref int _arg2)
		{
			vtkScalarsToTextureFilter.vtkScalarsToTextureFilter_GetTextureDimensions_04(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600EF3D RID: 61245
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToTextureFilter_GetTextureDimensions_05(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the width and height of the generated texture.
		/// Default is 128x128. The width and height must be greater than 1.
		/// </summary>
		// Token: 0x0600EF3E RID: 61246 RVA: 0x0014D9C5 File Offset: 0x0014BBC5
		public virtual void GetTextureDimensions(IntPtr _arg)
		{
			vtkScalarsToTextureFilter.vtkScalarsToTextureFilter_GetTextureDimensions_05(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EF3F RID: 61247
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarsToTextureFilter_GetTransferFunction_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get a color transfer function.
		/// This transfer function will be used to determine the pixel colors of the texture.
		/// If not specified, the filter use a default one (blue/white/red) based on the range of the
		/// input array.
		/// </summary>
		// Token: 0x0600EF40 RID: 61248 RVA: 0x0014D9D8 File Offset: 0x0014BBD8
		public vtkScalarsToColors GetTransferFunction()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarsToTextureFilter.vtkScalarsToTextureFilter_GetTransferFunction_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarsToColors = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarsToColors.Register(null);
				}
			}
			return vtkScalarsToColors;
		}

		// Token: 0x0600EF41 RID: 61249
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkScalarsToTextureFilter_GetUseTransferFunction_07(HandleRef pThis);

		/// <summary>
		/// Specify if a new point array containing RGBA values have to be computed by the specified
		/// color transfer function.
		/// </summary>
		// Token: 0x0600EF42 RID: 61250 RVA: 0x0014DA48 File Offset: 0x0014BC48
		public virtual bool GetUseTransferFunction()
		{
			return vtkScalarsToTextureFilter.vtkScalarsToTextureFilter_GetUseTransferFunction_07(base.GetCppThis()) != 0;
		}

		// Token: 0x0600EF43 RID: 61251
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarsToTextureFilter_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EF44 RID: 61252 RVA: 0x0014DA70 File Offset: 0x0014BC70
		public override int IsA(string type)
		{
			return vtkScalarsToTextureFilter.vtkScalarsToTextureFilter_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0600EF45 RID: 61253
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarsToTextureFilter_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EF46 RID: 61254 RVA: 0x0014DA90 File Offset: 0x0014BC90
		public new static int IsTypeOf(string type)
		{
			return vtkScalarsToTextureFilter.vtkScalarsToTextureFilter_IsTypeOf_09(type);
		}

		// Token: 0x0600EF47 RID: 61255
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarsToTextureFilter_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EF48 RID: 61256 RVA: 0x0014DAAC File Offset: 0x0014BCAC
		public new vtkScalarsToTextureFilter NewInstance()
		{
			vtkScalarsToTextureFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarsToTextureFilter.vtkScalarsToTextureFilter_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkScalarsToTextureFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600EF49 RID: 61257
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarsToTextureFilter_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EF4A RID: 61258 RVA: 0x0014DB08 File Offset: 0x0014BD08
		public new static vtkScalarsToTextureFilter SafeDownCast(vtkObjectBase o)
		{
			vtkScalarsToTextureFilter vtkScalarsToTextureFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarsToTextureFilter.vtkScalarsToTextureFilter_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarsToTextureFilter = (vtkScalarsToTextureFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarsToTextureFilter.Register(null);
				}
			}
			return vtkScalarsToTextureFilter;
		}

		// Token: 0x0600EF4B RID: 61259
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToTextureFilter_SetTextureDimensions_13(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Get/Set the width and height of the generated texture.
		/// Default is 128x128. The width and height must be greater than 1.
		/// </summary>
		// Token: 0x0600EF4C RID: 61260 RVA: 0x0014DB87 File Offset: 0x0014BD87
		public virtual void SetTextureDimensions(int _arg1, int _arg2)
		{
			vtkScalarsToTextureFilter.vtkScalarsToTextureFilter_SetTextureDimensions_13(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600EF4D RID: 61261
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToTextureFilter_SetTextureDimensions_14(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the width and height of the generated texture.
		/// Default is 128x128. The width and height must be greater than 1.
		/// </summary>
		// Token: 0x0600EF4E RID: 61262 RVA: 0x0014DB98 File Offset: 0x0014BD98
		public void SetTextureDimensions(IntPtr _arg)
		{
			vtkScalarsToTextureFilter.vtkScalarsToTextureFilter_SetTextureDimensions_14(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EF4F RID: 61263
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToTextureFilter_SetTransferFunction_15(HandleRef pThis, HandleRef stc);

		/// <summary>
		/// Set/Get a color transfer function.
		/// This transfer function will be used to determine the pixel colors of the texture.
		/// If not specified, the filter use a default one (blue/white/red) based on the range of the
		/// input array.
		/// </summary>
		// Token: 0x0600EF50 RID: 61264 RVA: 0x0014DBA8 File Offset: 0x0014BDA8
		public void SetTransferFunction(vtkScalarsToColors stc)
		{
			vtkScalarsToTextureFilter.vtkScalarsToTextureFilter_SetTransferFunction_15(base.GetCppThis(), (stc == null) ? default(HandleRef) : stc.GetCppThis());
		}

		// Token: 0x0600EF51 RID: 61265
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToTextureFilter_SetUseTransferFunction_16(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify if a new point array containing RGBA values have to be computed by the specified
		/// color transfer function.
		/// </summary>
		// Token: 0x0600EF52 RID: 61266 RVA: 0x0014DBD7 File Offset: 0x0014BDD7
		public virtual void SetUseTransferFunction(bool _arg)
		{
			vtkScalarsToTextureFilter.vtkScalarsToTextureFilter_SetUseTransferFunction_16(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600EF53 RID: 61267
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToTextureFilter_UseTransferFunctionOff_17(HandleRef pThis);

		/// <summary>
		/// Specify if a new point array containing RGBA values have to be computed by the specified
		/// color transfer function.
		/// </summary>
		// Token: 0x0600EF54 RID: 61268 RVA: 0x0014DBEF File Offset: 0x0014BDEF
		public virtual void UseTransferFunctionOff()
		{
			vtkScalarsToTextureFilter.vtkScalarsToTextureFilter_UseTransferFunctionOff_17(base.GetCppThis());
		}

		// Token: 0x0600EF55 RID: 61269
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToTextureFilter_UseTransferFunctionOn_18(HandleRef pThis);

		/// <summary>
		/// Specify if a new point array containing RGBA values have to be computed by the specified
		/// color transfer function.
		/// </summary>
		// Token: 0x0600EF56 RID: 61270 RVA: 0x0014DBFE File Offset: 0x0014BDFE
		public virtual void UseTransferFunctionOn()
		{
			vtkScalarsToTextureFilter.vtkScalarsToTextureFilter_UseTransferFunctionOn_18(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001178 RID: 4472
		public new const string MRFullTypeName = "Kitware.VTK.vtkScalarsToTextureFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001179 RID: 4473
		public new static readonly string MRClassNameKey = "class vtkScalarsToTextureFilter";
	}
}
