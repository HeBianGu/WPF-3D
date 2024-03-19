using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageSobel3D
	/// </summary>
	/// <remarks>
	///    Computes a vector field using sobel functions.
	///
	/// vtkImageSobel3D computes a vector field from a scalar field by using
	/// Sobel functions.  The number of vector components is 3 because
	/// the input is a volume.  Output is always doubles.  A little creative
	/// liberty was used to extend the 2D sobel kernels into 3D.
	/// </remarks>
	// Token: 0x02000492 RID: 1170
	public class vtkImageSobel3D : vtkImageSpatialAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D767 RID: 55143 RVA: 0x0012B6CF File Offset: 0x001298CF
		static vtkImageSobel3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageSobel3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageSobel3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D768 RID: 55144 RVA: 0x0012B6F7 File Offset: 0x001298F7
		public vtkImageSobel3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D769 RID: 55145
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSobel3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D76A RID: 55146 RVA: 0x0012B708 File Offset: 0x00129908
		public new static vtkImageSobel3D New()
		{
			vtkImageSobel3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSobel3D.vtkImageSobel3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSobel3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D76B RID: 55147 RVA: 0x0012B75C File Offset: 0x0012995C
		public vtkImageSobel3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageSobel3D.vtkImageSobel3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D76C RID: 55148 RVA: 0x0012B7A0 File Offset: 0x001299A0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D76D RID: 55149
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageSobel3D_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D76E RID: 55150 RVA: 0x0012B7AC File Offset: 0x001299AC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageSobel3D.vtkImageSobel3D_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600D76F RID: 55151
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageSobel3D_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D770 RID: 55152 RVA: 0x0012B7CC File Offset: 0x001299CC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageSobel3D.vtkImageSobel3D_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600D771 RID: 55153
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSobel3D_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D772 RID: 55154 RVA: 0x0012B7E8 File Offset: 0x001299E8
		public override int IsA(string type)
		{
			return vtkImageSobel3D.vtkImageSobel3D_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600D773 RID: 55155
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSobel3D_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D774 RID: 55156 RVA: 0x0012B808 File Offset: 0x00129A08
		public new static int IsTypeOf(string type)
		{
			return vtkImageSobel3D.vtkImageSobel3D_IsTypeOf_04(type);
		}

		// Token: 0x0600D775 RID: 55157
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSobel3D_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D776 RID: 55158 RVA: 0x0012B824 File Offset: 0x00129A24
		public new vtkImageSobel3D NewInstance()
		{
			vtkImageSobel3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSobel3D.vtkImageSobel3D_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSobel3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D777 RID: 55159
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSobel3D_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D778 RID: 55160 RVA: 0x0012B880 File Offset: 0x00129A80
		public new static vtkImageSobel3D SafeDownCast(vtkObjectBase o)
		{
			vtkImageSobel3D vtkImageSobel3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSobel3D.vtkImageSobel3D_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageSobel3D = (vtkImageSobel3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageSobel3D.Register(null);
				}
			}
			return vtkImageSobel3D;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FCC RID: 4044
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageSobel3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FCD RID: 4045
		public new static readonly string MRClassNameKey = "class vtkImageSobel3D";
	}
}
