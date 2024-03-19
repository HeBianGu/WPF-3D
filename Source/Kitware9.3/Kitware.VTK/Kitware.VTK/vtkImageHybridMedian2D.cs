using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageHybridMedian2D
	/// </summary>
	/// <remarks>
	///    Median filter that preserves lines and
	/// corners.
	///
	/// vtkImageHybridMedian2D is a median filter that preserves thin lines and
	/// corners.  It operates on a 5x5 pixel neighborhood.  It computes two values
	/// initially: the median of the + neighbors and the median of the x
	/// neighbors.  It then computes the median of these two values plus the center
	/// pixel.  This result of this second median is the output pixel value.
	/// </remarks>
	// Token: 0x02000488 RID: 1160
	public class vtkImageHybridMedian2D : vtkImageSpatialAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D54B RID: 54603 RVA: 0x00128B8F File Offset: 0x00126D8F
		static vtkImageHybridMedian2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageHybridMedian2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageHybridMedian2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D54C RID: 54604 RVA: 0x00128BB7 File Offset: 0x00126DB7
		public vtkImageHybridMedian2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D54D RID: 54605
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageHybridMedian2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D54E RID: 54606 RVA: 0x00128BC8 File Offset: 0x00126DC8
		public new static vtkImageHybridMedian2D New()
		{
			vtkImageHybridMedian2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageHybridMedian2D.vtkImageHybridMedian2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageHybridMedian2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D54F RID: 54607 RVA: 0x00128C1C File Offset: 0x00126E1C
		public vtkImageHybridMedian2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageHybridMedian2D.vtkImageHybridMedian2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D550 RID: 54608 RVA: 0x00128C60 File Offset: 0x00126E60
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D551 RID: 54609
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageHybridMedian2D_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D552 RID: 54610 RVA: 0x00128C6C File Offset: 0x00126E6C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageHybridMedian2D.vtkImageHybridMedian2D_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600D553 RID: 54611
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageHybridMedian2D_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D554 RID: 54612 RVA: 0x00128C8C File Offset: 0x00126E8C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageHybridMedian2D.vtkImageHybridMedian2D_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600D555 RID: 54613
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageHybridMedian2D_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D556 RID: 54614 RVA: 0x00128CA8 File Offset: 0x00126EA8
		public override int IsA(string type)
		{
			return vtkImageHybridMedian2D.vtkImageHybridMedian2D_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600D557 RID: 54615
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageHybridMedian2D_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D558 RID: 54616 RVA: 0x00128CC8 File Offset: 0x00126EC8
		public new static int IsTypeOf(string type)
		{
			return vtkImageHybridMedian2D.vtkImageHybridMedian2D_IsTypeOf_04(type);
		}

		// Token: 0x0600D559 RID: 54617
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageHybridMedian2D_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D55A RID: 54618 RVA: 0x00128CE4 File Offset: 0x00126EE4
		public new vtkImageHybridMedian2D NewInstance()
		{
			vtkImageHybridMedian2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageHybridMedian2D.vtkImageHybridMedian2D_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageHybridMedian2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D55B RID: 54619
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageHybridMedian2D_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D55C RID: 54620 RVA: 0x00128D40 File Offset: 0x00126F40
		public new static vtkImageHybridMedian2D SafeDownCast(vtkObjectBase o)
		{
			vtkImageHybridMedian2D vtkImageHybridMedian2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageHybridMedian2D.vtkImageHybridMedian2D_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageHybridMedian2D = (vtkImageHybridMedian2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageHybridMedian2D.Register(null);
				}
			}
			return vtkImageHybridMedian2D;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FB8 RID: 4024
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageHybridMedian2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FB9 RID: 4025
		public new static readonly string MRClassNameKey = "class vtkImageHybridMedian2D";
	}
}
