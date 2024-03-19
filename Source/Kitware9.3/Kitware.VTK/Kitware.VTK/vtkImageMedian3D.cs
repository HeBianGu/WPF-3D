using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageMedian3D
	/// </summary>
	/// <remarks>
	///    Median Filter
	///
	/// vtkImageMedian3D a Median filter that replaces each pixel with the
	/// median value from a rectangular neighborhood around that pixel.
	/// Neighborhoods can be no more than 3 dimensional.  Setting one
	/// axis of the neighborhood kernelSize to 1 changes the filter
	/// into a 2D median.
	/// </remarks>
	// Token: 0x0200048A RID: 1162
	public class vtkImageMedian3D : vtkImageSpatialAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D577 RID: 54647 RVA: 0x0012905F File Offset: 0x0012725F
		static vtkImageMedian3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageMedian3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMedian3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D578 RID: 54648 RVA: 0x00129087 File Offset: 0x00127287
		public vtkImageMedian3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D579 RID: 54649
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMedian3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D57A RID: 54650 RVA: 0x00129098 File Offset: 0x00127298
		public new static vtkImageMedian3D New()
		{
			vtkImageMedian3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMedian3D.vtkImageMedian3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMedian3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D57B RID: 54651 RVA: 0x001290EC File Offset: 0x001272EC
		public vtkImageMedian3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageMedian3D.vtkImageMedian3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D57C RID: 54652 RVA: 0x00129130 File Offset: 0x00127330
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D57D RID: 54653
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMedian3D_GetNumberOfElements_01(HandleRef pThis);

		/// <summary>
		/// Return the number of elements in the median mask
		/// </summary>
		// Token: 0x0600D57E RID: 54654 RVA: 0x0012913C File Offset: 0x0012733C
		public virtual int GetNumberOfElements()
		{
			return vtkImageMedian3D.vtkImageMedian3D_GetNumberOfElements_01(base.GetCppThis());
		}

		// Token: 0x0600D57F RID: 54655
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageMedian3D_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D580 RID: 54656 RVA: 0x0012915C File Offset: 0x0012735C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageMedian3D.vtkImageMedian3D_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600D581 RID: 54657
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageMedian3D_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D582 RID: 54658 RVA: 0x0012917C File Offset: 0x0012737C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageMedian3D.vtkImageMedian3D_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600D583 RID: 54659
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMedian3D_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D584 RID: 54660 RVA: 0x00129198 File Offset: 0x00127398
		public override int IsA(string type)
		{
			return vtkImageMedian3D.vtkImageMedian3D_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600D585 RID: 54661
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMedian3D_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D586 RID: 54662 RVA: 0x001291B8 File Offset: 0x001273B8
		public new static int IsTypeOf(string type)
		{
			return vtkImageMedian3D.vtkImageMedian3D_IsTypeOf_05(type);
		}

		// Token: 0x0600D587 RID: 54663
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMedian3D_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D588 RID: 54664 RVA: 0x001291D4 File Offset: 0x001273D4
		public new vtkImageMedian3D NewInstance()
		{
			vtkImageMedian3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMedian3D.vtkImageMedian3D_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMedian3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D589 RID: 54665
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMedian3D_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D58A RID: 54666 RVA: 0x00129230 File Offset: 0x00127430
		public new static vtkImageMedian3D SafeDownCast(vtkObjectBase o)
		{
			vtkImageMedian3D vtkImageMedian3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMedian3D.vtkImageMedian3D_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMedian3D = (vtkImageMedian3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMedian3D.Register(null);
				}
			}
			return vtkImageMedian3D;
		}

		// Token: 0x0600D58B RID: 54667
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMedian3D_SetKernelSize_09(HandleRef pThis, int size0, int size1, int size2);

		/// <summary>
		/// This method sets the size of the neighborhood.  It also sets the
		/// default middle of the neighborhood
		/// </summary>
		// Token: 0x0600D58C RID: 54668 RVA: 0x001292AF File Offset: 0x001274AF
		public void SetKernelSize(int size0, int size1, int size2)
		{
			vtkImageMedian3D.vtkImageMedian3D_SetKernelSize_09(base.GetCppThis(), size0, size1, size2);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FBC RID: 4028
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageMedian3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FBD RID: 4029
		public new static readonly string MRClassNameKey = "class vtkImageMedian3D";
	}
}
