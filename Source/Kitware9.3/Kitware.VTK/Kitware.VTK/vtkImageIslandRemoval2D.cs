using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageIslandRemoval2D
	/// </summary>
	/// <remarks>
	///    Removes small clusters in masks.
	///
	/// vtkImageIslandRemoval2D computes the area of separate islands in
	/// a mask image.  It removes any island that has less than AreaThreshold
	/// pixels.  Output has the same ScalarType as input.  It generates
	/// the whole 2D output image for any output request.
	/// </remarks>
	// Token: 0x0200024B RID: 587
	public class vtkImageIslandRemoval2D : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006CCB RID: 27851 RVA: 0x0009D079 File Offset: 0x0009B279
		static vtkImageIslandRemoval2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageIslandRemoval2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageIslandRemoval2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006CCC RID: 27852 RVA: 0x0009D0A1 File Offset: 0x0009B2A1
		public vtkImageIslandRemoval2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006CCD RID: 27853
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageIslandRemoval2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Constructor: Sets default filter to be identity.
		/// </summary>
		// Token: 0x06006CCE RID: 27854 RVA: 0x0009D0B0 File Offset: 0x0009B2B0
		public new static vtkImageIslandRemoval2D New()
		{
			vtkImageIslandRemoval2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageIslandRemoval2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Constructor: Sets default filter to be identity.
		/// </summary>
		// Token: 0x06006CCF RID: 27855 RVA: 0x0009D104 File Offset: 0x0009B304
		public vtkImageIslandRemoval2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006CD0 RID: 27856 RVA: 0x0009D148 File Offset: 0x0009B348
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006CD1 RID: 27857
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageIslandRemoval2D_GetAreaThreshold_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the cutoff area for removal
		/// </summary>
		// Token: 0x06006CD2 RID: 27858 RVA: 0x0009D154 File Offset: 0x0009B354
		public virtual int GetAreaThreshold()
		{
			return vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_GetAreaThreshold_01(base.GetCppThis());
		}

		// Token: 0x06006CD3 RID: 27859
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageIslandRemoval2D_GetIslandValue_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the value to remove.
		/// </summary>
		// Token: 0x06006CD4 RID: 27860 RVA: 0x0009D174 File Offset: 0x0009B374
		public virtual double GetIslandValue()
		{
			return vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_GetIslandValue_02(base.GetCppThis());
		}

		// Token: 0x06006CD5 RID: 27861
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageIslandRemoval2D_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Constructor: Sets default filter to be identity.
		/// </summary>
		// Token: 0x06006CD6 RID: 27862 RVA: 0x0009D194 File Offset: 0x0009B394
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06006CD7 RID: 27863
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageIslandRemoval2D_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Constructor: Sets default filter to be identity.
		/// </summary>
		// Token: 0x06006CD8 RID: 27864 RVA: 0x0009D1B4 File Offset: 0x0009B3B4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06006CD9 RID: 27865
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageIslandRemoval2D_GetReplaceValue_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the value to put in the place of removed pixels.
		/// </summary>
		// Token: 0x06006CDA RID: 27866 RVA: 0x0009D1D0 File Offset: 0x0009B3D0
		public virtual double GetReplaceValue()
		{
			return vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_GetReplaceValue_05(base.GetCppThis());
		}

		// Token: 0x06006CDB RID: 27867
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageIslandRemoval2D_GetSquareNeighborhood_06(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to use 4 or 8 neighbors
		/// </summary>
		// Token: 0x06006CDC RID: 27868 RVA: 0x0009D1F0 File Offset: 0x0009B3F0
		public virtual int GetSquareNeighborhood()
		{
			return vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_GetSquareNeighborhood_06(base.GetCppThis());
		}

		// Token: 0x06006CDD RID: 27869
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageIslandRemoval2D_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Constructor: Sets default filter to be identity.
		/// </summary>
		// Token: 0x06006CDE RID: 27870 RVA: 0x0009D210 File Offset: 0x0009B410
		public override int IsA(string type)
		{
			return vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06006CDF RID: 27871
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageIslandRemoval2D_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Constructor: Sets default filter to be identity.
		/// </summary>
		// Token: 0x06006CE0 RID: 27872 RVA: 0x0009D230 File Offset: 0x0009B430
		public new static int IsTypeOf(string type)
		{
			return vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_IsTypeOf_08(type);
		}

		// Token: 0x06006CE1 RID: 27873
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageIslandRemoval2D_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Constructor: Sets default filter to be identity.
		/// </summary>
		// Token: 0x06006CE2 RID: 27874 RVA: 0x0009D24C File Offset: 0x0009B44C
		public new vtkImageIslandRemoval2D NewInstance()
		{
			vtkImageIslandRemoval2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageIslandRemoval2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006CE3 RID: 27875
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageIslandRemoval2D_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Constructor: Sets default filter to be identity.
		/// </summary>
		// Token: 0x06006CE4 RID: 27876 RVA: 0x0009D2A8 File Offset: 0x0009B4A8
		public new static vtkImageIslandRemoval2D SafeDownCast(vtkObjectBase o)
		{
			vtkImageIslandRemoval2D vtkImageIslandRemoval2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageIslandRemoval2D = (vtkImageIslandRemoval2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageIslandRemoval2D.Register(null);
				}
			}
			return vtkImageIslandRemoval2D;
		}

		// Token: 0x06006CE5 RID: 27877
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageIslandRemoval2D_SetAreaThreshold_12(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the cutoff area for removal
		/// </summary>
		// Token: 0x06006CE6 RID: 27878 RVA: 0x0009D327 File Offset: 0x0009B527
		public virtual void SetAreaThreshold(int _arg)
		{
			vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_SetAreaThreshold_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06006CE7 RID: 27879
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageIslandRemoval2D_SetIslandValue_13(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the value to remove.
		/// </summary>
		// Token: 0x06006CE8 RID: 27880 RVA: 0x0009D337 File Offset: 0x0009B537
		public virtual void SetIslandValue(double _arg)
		{
			vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_SetIslandValue_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06006CE9 RID: 27881
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageIslandRemoval2D_SetReplaceValue_14(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the value to put in the place of removed pixels.
		/// </summary>
		// Token: 0x06006CEA RID: 27882 RVA: 0x0009D347 File Offset: 0x0009B547
		public virtual void SetReplaceValue(double _arg)
		{
			vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_SetReplaceValue_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06006CEB RID: 27883
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageIslandRemoval2D_SetSquareNeighborhood_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get whether to use 4 or 8 neighbors
		/// </summary>
		// Token: 0x06006CEC RID: 27884 RVA: 0x0009D357 File Offset: 0x0009B557
		public virtual void SetSquareNeighborhood(int _arg)
		{
			vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_SetSquareNeighborhood_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06006CED RID: 27885
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageIslandRemoval2D_SquareNeighborhoodOff_16(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to use 4 or 8 neighbors
		/// </summary>
		// Token: 0x06006CEE RID: 27886 RVA: 0x0009D367 File Offset: 0x0009B567
		public virtual void SquareNeighborhoodOff()
		{
			vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_SquareNeighborhoodOff_16(base.GetCppThis());
		}

		// Token: 0x06006CEF RID: 27887
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageIslandRemoval2D_SquareNeighborhoodOn_17(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to use 4 or 8 neighbors
		/// </summary>
		// Token: 0x06006CF0 RID: 27888 RVA: 0x0009D376 File Offset: 0x0009B576
		public virtual void SquareNeighborhoodOn()
		{
			vtkImageIslandRemoval2D.vtkImageIslandRemoval2D_SquareNeighborhoodOn_17(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400098B RID: 2443
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageIslandRemoval2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400098C RID: 2444
		public new static readonly string MRClassNameKey = "class vtkImageIslandRemoval2D";
	}
}
