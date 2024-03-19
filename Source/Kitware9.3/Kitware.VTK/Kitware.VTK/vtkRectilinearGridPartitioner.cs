using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRectilinearGridPartitioner
	///
	///
	///  A concrete implementation of vtkMultiBlockDataSetAlgorithm that provides
	///  functionality for partitioning a VTK rectilinear dataset. The partitioning
	///  method used is Recursive Coordinate Bisection (RCB) where each time the
	///  longest dimension is split.
	///
	/// </summary>
	/// <seealso>
	///
	///  vtkUniformGridPartitioner vtkStructuredGridPartitioner
	/// </seealso>
	// Token: 0x02000912 RID: 2322
	public class vtkRectilinearGridPartitioner : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060180F4 RID: 98548 RVA: 0x0021AB7F File Offset: 0x00218D7F
		static vtkRectilinearGridPartitioner()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRectilinearGridPartitioner.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectilinearGridPartitioner"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060180F5 RID: 98549 RVA: 0x0021ABA7 File Offset: 0x00218DA7
		public vtkRectilinearGridPartitioner(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060180F6 RID: 98550
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridPartitioner_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060180F7 RID: 98551 RVA: 0x0021ABB8 File Offset: 0x00218DB8
		public new static vtkRectilinearGridPartitioner New()
		{
			vtkRectilinearGridPartitioner result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridPartitioner.vtkRectilinearGridPartitioner_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearGridPartitioner)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060180F8 RID: 98552 RVA: 0x0021AC0C File Offset: 0x00218E0C
		public vtkRectilinearGridPartitioner() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRectilinearGridPartitioner.vtkRectilinearGridPartitioner_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060180F9 RID: 98553 RVA: 0x0021AC50 File Offset: 0x00218E50
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060180FA RID: 98554
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridPartitioner_DuplicateNodesOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get macro for the number of ghost layers.
		/// </summary>
		// Token: 0x060180FB RID: 98555 RVA: 0x0021AC5B File Offset: 0x00218E5B
		public virtual void DuplicateNodesOff()
		{
			vtkRectilinearGridPartitioner.vtkRectilinearGridPartitioner_DuplicateNodesOff_01(base.GetCppThis());
		}

		// Token: 0x060180FC RID: 98556
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridPartitioner_DuplicateNodesOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get macro for the number of ghost layers.
		/// </summary>
		// Token: 0x060180FD RID: 98557 RVA: 0x0021AC6A File Offset: 0x00218E6A
		public virtual void DuplicateNodesOn()
		{
			vtkRectilinearGridPartitioner.vtkRectilinearGridPartitioner_DuplicateNodesOn_02(base.GetCppThis());
		}

		// Token: 0x060180FE RID: 98558
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGridPartitioner_GetDuplicateNodes_03(HandleRef pThis);

		/// <summary>
		/// Set/Get macro for the number of ghost layers.
		/// </summary>
		// Token: 0x060180FF RID: 98559 RVA: 0x0021AC7C File Offset: 0x00218E7C
		public virtual int GetDuplicateNodes()
		{
			return vtkRectilinearGridPartitioner.vtkRectilinearGridPartitioner_GetDuplicateNodes_03(base.GetCppThis());
		}

		// Token: 0x06018100 RID: 98560
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearGridPartitioner_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018101 RID: 98561 RVA: 0x0021AC9C File Offset: 0x00218E9C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRectilinearGridPartitioner.vtkRectilinearGridPartitioner_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06018102 RID: 98562
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearGridPartitioner_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018103 RID: 98563 RVA: 0x0021ACBC File Offset: 0x00218EBC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRectilinearGridPartitioner.vtkRectilinearGridPartitioner_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06018104 RID: 98564
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGridPartitioner_GetNumberOfGhostLayers_06(HandleRef pThis);

		/// <summary>
		/// Set/Get macro for the number of ghost layers.
		/// </summary>
		// Token: 0x06018105 RID: 98565 RVA: 0x0021ACD8 File Offset: 0x00218ED8
		public virtual int GetNumberOfGhostLayers()
		{
			return vtkRectilinearGridPartitioner.vtkRectilinearGridPartitioner_GetNumberOfGhostLayers_06(base.GetCppThis());
		}

		// Token: 0x06018106 RID: 98566
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGridPartitioner_GetNumberOfPartitions_07(HandleRef pThis);

		/// <summary>
		/// Set/Get macro for the number of subdivisions.
		/// </summary>
		// Token: 0x06018107 RID: 98567 RVA: 0x0021ACF8 File Offset: 0x00218EF8
		public virtual int GetNumberOfPartitions()
		{
			return vtkRectilinearGridPartitioner.vtkRectilinearGridPartitioner_GetNumberOfPartitions_07(base.GetCppThis());
		}

		// Token: 0x06018108 RID: 98568
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGridPartitioner_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018109 RID: 98569 RVA: 0x0021AD18 File Offset: 0x00218F18
		public override int IsA(string type)
		{
			return vtkRectilinearGridPartitioner.vtkRectilinearGridPartitioner_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0601810A RID: 98570
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGridPartitioner_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601810B RID: 98571 RVA: 0x0021AD38 File Offset: 0x00218F38
		public new static int IsTypeOf(string type)
		{
			return vtkRectilinearGridPartitioner.vtkRectilinearGridPartitioner_IsTypeOf_09(type);
		}

		// Token: 0x0601810C RID: 98572
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridPartitioner_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601810D RID: 98573 RVA: 0x0021AD54 File Offset: 0x00218F54
		public new vtkRectilinearGridPartitioner NewInstance()
		{
			vtkRectilinearGridPartitioner result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridPartitioner.vtkRectilinearGridPartitioner_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearGridPartitioner)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601810E RID: 98574
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridPartitioner_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601810F RID: 98575 RVA: 0x0021ADB0 File Offset: 0x00218FB0
		public new static vtkRectilinearGridPartitioner SafeDownCast(vtkObjectBase o)
		{
			vtkRectilinearGridPartitioner vtkRectilinearGridPartitioner = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridPartitioner.vtkRectilinearGridPartitioner_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearGridPartitioner = (vtkRectilinearGridPartitioner)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearGridPartitioner.Register(null);
				}
			}
			return vtkRectilinearGridPartitioner;
		}

		// Token: 0x06018110 RID: 98576
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridPartitioner_SetDuplicateNodes_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get macro for the number of ghost layers.
		/// </summary>
		// Token: 0x06018111 RID: 98577 RVA: 0x0021AE2F File Offset: 0x0021902F
		public virtual void SetDuplicateNodes(int _arg)
		{
			vtkRectilinearGridPartitioner.vtkRectilinearGridPartitioner_SetDuplicateNodes_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06018112 RID: 98578
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridPartitioner_SetNumberOfGhostLayers_14(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get macro for the number of ghost layers.
		/// </summary>
		// Token: 0x06018113 RID: 98579 RVA: 0x0021AE3F File Offset: 0x0021903F
		public virtual void SetNumberOfGhostLayers(int _arg)
		{
			vtkRectilinearGridPartitioner.vtkRectilinearGridPartitioner_SetNumberOfGhostLayers_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06018114 RID: 98580
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridPartitioner_SetNumberOfPartitions_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get macro for the number of subdivisions.
		/// </summary>
		// Token: 0x06018115 RID: 98581 RVA: 0x0021AE4F File Offset: 0x0021904F
		public virtual void SetNumberOfPartitions(int _arg)
		{
			vtkRectilinearGridPartitioner.vtkRectilinearGridPartitioner_SetNumberOfPartitions_15(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001ACE RID: 6862
		public new const string MRFullTypeName = "Kitware.VTK.vtkRectilinearGridPartitioner";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001ACF RID: 6863
		public new static readonly string MRClassNameKey = "class vtkRectilinearGridPartitioner";
	}
}
