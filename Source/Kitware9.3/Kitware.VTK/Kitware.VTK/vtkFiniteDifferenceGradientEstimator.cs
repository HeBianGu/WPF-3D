using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFiniteDifferenceGradientEstimator
	/// </summary>
	/// <remarks>
	///    Use finite differences to estimate gradient.
	///
	///
	///  vtkFiniteDifferenceGradientEstimator is a concrete subclass of
	///  vtkEncodedGradientEstimator that uses a central differences technique to
	///  estimate the gradient. The gradient at some sample location (x,y,z)
	///  would be estimated by:
	///
	///       nx = (f(x-dx,y,z) - f(x+dx,y,z)) / 2*dx;
	///       ny = (f(x,y-dy,z) - f(x,y+dy,z)) / 2*dy;
	///       nz = (f(x,y,z-dz) - f(x,y,z+dz)) / 2*dz;
	///
	///  This value is normalized to determine a unit direction vector and a
	///  magnitude. The normal is computed in voxel space, and
	///  dx = dy = dz = SampleSpacingInVoxels. A scaling factor is applied to
	///  convert this normal from voxel space to world coordinates.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkEncodedGradientEstimator
	/// </seealso>
	// Token: 0x02000394 RID: 916
	public class vtkFiniteDifferenceGradientEstimator : vtkEncodedGradientEstimator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A6B7 RID: 42679 RVA: 0x000EC811 File Offset: 0x000EAA11
		static vtkFiniteDifferenceGradientEstimator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFiniteDifferenceGradientEstimator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFiniteDifferenceGradientEstimator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A6B8 RID: 42680 RVA: 0x000EC839 File Offset: 0x000EAA39
		public vtkFiniteDifferenceGradientEstimator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A6B9 RID: 42681
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFiniteDifferenceGradientEstimator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a vtkFiniteDifferenceGradientEstimator with
		/// a SampleSpacingInVoxels of 1.
		/// </summary>
		// Token: 0x0600A6BA RID: 42682 RVA: 0x000EC848 File Offset: 0x000EAA48
		public new static vtkFiniteDifferenceGradientEstimator New()
		{
			vtkFiniteDifferenceGradientEstimator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFiniteDifferenceGradientEstimator.vtkFiniteDifferenceGradientEstimator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFiniteDifferenceGradientEstimator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct a vtkFiniteDifferenceGradientEstimator with
		/// a SampleSpacingInVoxels of 1.
		/// </summary>
		// Token: 0x0600A6BB RID: 42683 RVA: 0x000EC89C File Offset: 0x000EAA9C
		public vtkFiniteDifferenceGradientEstimator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFiniteDifferenceGradientEstimator.vtkFiniteDifferenceGradientEstimator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A6BC RID: 42684 RVA: 0x000EC8E0 File Offset: 0x000EAAE0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A6BD RID: 42685
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFiniteDifferenceGradientEstimator_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A6BE RID: 42686 RVA: 0x000EC8EC File Offset: 0x000EAAEC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFiniteDifferenceGradientEstimator.vtkFiniteDifferenceGradientEstimator_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600A6BF RID: 42687
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFiniteDifferenceGradientEstimator_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A6C0 RID: 42688 RVA: 0x000EC90C File Offset: 0x000EAB0C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFiniteDifferenceGradientEstimator.vtkFiniteDifferenceGradientEstimator_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600A6C1 RID: 42689
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFiniteDifferenceGradientEstimator_GetSampleSpacingInVoxels_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the spacing between samples for the finite differences
		/// method used to compute the normal. This spacing is in voxel units.
		/// </summary>
		// Token: 0x0600A6C2 RID: 42690 RVA: 0x000EC928 File Offset: 0x000EAB28
		public virtual int GetSampleSpacingInVoxels()
		{
			return vtkFiniteDifferenceGradientEstimator.vtkFiniteDifferenceGradientEstimator_GetSampleSpacingInVoxels_03(base.GetCppThis());
		}

		// Token: 0x0600A6C3 RID: 42691
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFiniteDifferenceGradientEstimator_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A6C4 RID: 42692 RVA: 0x000EC948 File Offset: 0x000EAB48
		public override int IsA(string type)
		{
			return vtkFiniteDifferenceGradientEstimator.vtkFiniteDifferenceGradientEstimator_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600A6C5 RID: 42693
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFiniteDifferenceGradientEstimator_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A6C6 RID: 42694 RVA: 0x000EC968 File Offset: 0x000EAB68
		public new static int IsTypeOf(string type)
		{
			return vtkFiniteDifferenceGradientEstimator.vtkFiniteDifferenceGradientEstimator_IsTypeOf_05(type);
		}

		// Token: 0x0600A6C7 RID: 42695
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFiniteDifferenceGradientEstimator_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A6C8 RID: 42696 RVA: 0x000EC984 File Offset: 0x000EAB84
		public new vtkFiniteDifferenceGradientEstimator NewInstance()
		{
			vtkFiniteDifferenceGradientEstimator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFiniteDifferenceGradientEstimator.vtkFiniteDifferenceGradientEstimator_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFiniteDifferenceGradientEstimator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A6C9 RID: 42697
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFiniteDifferenceGradientEstimator_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A6CA RID: 42698 RVA: 0x000EC9E0 File Offset: 0x000EABE0
		public new static vtkFiniteDifferenceGradientEstimator SafeDownCast(vtkObjectBase o)
		{
			vtkFiniteDifferenceGradientEstimator vtkFiniteDifferenceGradientEstimator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFiniteDifferenceGradientEstimator.vtkFiniteDifferenceGradientEstimator_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFiniteDifferenceGradientEstimator = (vtkFiniteDifferenceGradientEstimator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFiniteDifferenceGradientEstimator.Register(null);
				}
			}
			return vtkFiniteDifferenceGradientEstimator;
		}

		// Token: 0x0600A6CB RID: 42699
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFiniteDifferenceGradientEstimator_SetSampleSpacingInVoxels_09(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the spacing between samples for the finite differences
		/// method used to compute the normal. This spacing is in voxel units.
		/// </summary>
		// Token: 0x0600A6CC RID: 42700 RVA: 0x000ECA5F File Offset: 0x000EAC5F
		public virtual void SetSampleSpacingInVoxels(int _arg)
		{
			vtkFiniteDifferenceGradientEstimator.vtkFiniteDifferenceGradientEstimator_SetSampleSpacingInVoxels_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D5D RID: 3421
		public new const string MRFullTypeName = "Kitware.VTK.vtkFiniteDifferenceGradientEstimator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D5E RID: 3422
		public new static readonly string MRClassNameKey = "class vtkFiniteDifferenceGradientEstimator";
	}
}
