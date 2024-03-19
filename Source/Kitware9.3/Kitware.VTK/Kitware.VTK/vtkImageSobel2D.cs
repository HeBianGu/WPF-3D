using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageSobel2D
	/// </summary>
	/// <remarks>
	///    Computes a vector field using sobel functions.
	///
	/// vtkImageSobel2D computes a vector field from a scalar field by using
	/// Sobel functions.  The number of vector components is 2 because
	/// the input is an image.  Output is always doubles.
	/// </remarks>
	// Token: 0x02000491 RID: 1169
	public class vtkImageSobel2D : vtkImageSpatialAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D755 RID: 55125 RVA: 0x0012B4A0 File Offset: 0x001296A0
		static vtkImageSobel2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageSobel2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageSobel2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D756 RID: 55126 RVA: 0x0012B4C8 File Offset: 0x001296C8
		public vtkImageSobel2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D757 RID: 55127
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSobel2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D758 RID: 55128 RVA: 0x0012B4D8 File Offset: 0x001296D8
		public new static vtkImageSobel2D New()
		{
			vtkImageSobel2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSobel2D.vtkImageSobel2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSobel2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D759 RID: 55129 RVA: 0x0012B52C File Offset: 0x0012972C
		public vtkImageSobel2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageSobel2D.vtkImageSobel2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D75A RID: 55130 RVA: 0x0012B570 File Offset: 0x00129770
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D75B RID: 55131
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageSobel2D_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D75C RID: 55132 RVA: 0x0012B57C File Offset: 0x0012977C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageSobel2D.vtkImageSobel2D_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600D75D RID: 55133
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageSobel2D_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D75E RID: 55134 RVA: 0x0012B59C File Offset: 0x0012979C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageSobel2D.vtkImageSobel2D_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600D75F RID: 55135
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSobel2D_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D760 RID: 55136 RVA: 0x0012B5B8 File Offset: 0x001297B8
		public override int IsA(string type)
		{
			return vtkImageSobel2D.vtkImageSobel2D_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600D761 RID: 55137
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSobel2D_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D762 RID: 55138 RVA: 0x0012B5D8 File Offset: 0x001297D8
		public new static int IsTypeOf(string type)
		{
			return vtkImageSobel2D.vtkImageSobel2D_IsTypeOf_04(type);
		}

		// Token: 0x0600D763 RID: 55139
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSobel2D_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D764 RID: 55140 RVA: 0x0012B5F4 File Offset: 0x001297F4
		public new vtkImageSobel2D NewInstance()
		{
			vtkImageSobel2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSobel2D.vtkImageSobel2D_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSobel2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D765 RID: 55141
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSobel2D_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D766 RID: 55142 RVA: 0x0012B650 File Offset: 0x00129850
		public new static vtkImageSobel2D SafeDownCast(vtkObjectBase o)
		{
			vtkImageSobel2D vtkImageSobel2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSobel2D.vtkImageSobel2D_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageSobel2D = (vtkImageSobel2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageSobel2D.Register(null);
				}
			}
			return vtkImageSobel2D;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FCA RID: 4042
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageSobel2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FCB RID: 4043
		public new static readonly string MRClassNameKey = "class vtkImageSobel2D";
	}
}
