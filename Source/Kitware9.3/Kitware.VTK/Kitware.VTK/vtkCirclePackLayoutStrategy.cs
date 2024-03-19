using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCirclePackLayoutStrategy
	/// </summary>
	/// <remarks>
	///    abstract superclass for all circle packing
	/// layout strategies.
	///
	///
	/// All subclasses of this class perform a circle packing layout on a vtkTree.
	/// This involves assigning a circle to each vertex in the tree,
	/// and placing that information in a data array with three components per
	/// tuple representing (Xcenter, Ycenter, Radius).
	///
	/// Instances of subclasses of this class may be assigned as the layout
	/// strategy to vtkCirclePackLayout
	///
	/// @par Thanks:
	/// Thanks to Thomas Otahal from Sandia National Laboratories
	/// for help developing this class.
	/// </remarks>
	// Token: 0x02000282 RID: 642
	public abstract class vtkCirclePackLayoutStrategy : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007455 RID: 29781 RVA: 0x000A82DB File Offset: 0x000A64DB
		static vtkCirclePackLayoutStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCirclePackLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCirclePackLayoutStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007456 RID: 29782 RVA: 0x000A8303 File Offset: 0x000A6503
		public vtkCirclePackLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007457 RID: 29783 RVA: 0x000A8311 File Offset: 0x000A6511
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007458 RID: 29784
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCirclePackLayoutStrategy_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007459 RID: 29785 RVA: 0x000A831C File Offset: 0x000A651C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCirclePackLayoutStrategy.vtkCirclePackLayoutStrategy_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600745A RID: 29786
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCirclePackLayoutStrategy_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600745B RID: 29787 RVA: 0x000A833C File Offset: 0x000A653C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCirclePackLayoutStrategy.vtkCirclePackLayoutStrategy_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600745C RID: 29788
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCirclePackLayoutStrategy_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600745D RID: 29789 RVA: 0x000A8358 File Offset: 0x000A6558
		public override int IsA(string type)
		{
			return vtkCirclePackLayoutStrategy.vtkCirclePackLayoutStrategy_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600745E RID: 29790
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCirclePackLayoutStrategy_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600745F RID: 29791 RVA: 0x000A8378 File Offset: 0x000A6578
		public new static int IsTypeOf(string type)
		{
			return vtkCirclePackLayoutStrategy.vtkCirclePackLayoutStrategy_IsTypeOf_04(type);
		}

		// Token: 0x06007460 RID: 29792
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCirclePackLayoutStrategy_Layout_05(HandleRef pThis, HandleRef inputTree, HandleRef areaArray, HandleRef sizeArray);

		/// <summary>
		/// Perform the layout of the input tree, and store the circle
		/// bounds of each vertex as a tuple in a data array.
		/// (Xcenter, Ycenter, Radius).
		///
		/// The sizeArray may be nullptr, or may contain the desired
		/// size of each vertex in the tree.
		/// </summary>
		// Token: 0x06007461 RID: 29793 RVA: 0x000A8394 File Offset: 0x000A6594
		public virtual void Layout(vtkTree inputTree, vtkDataArray areaArray, vtkDataArray sizeArray)
		{
			vtkCirclePackLayoutStrategy.vtkCirclePackLayoutStrategy_Layout_05(base.GetCppThis(), (inputTree == null) ? default(HandleRef) : inputTree.GetCppThis(), (areaArray == null) ? default(HandleRef) : areaArray.GetCppThis(), (sizeArray == null) ? default(HandleRef) : sizeArray.GetCppThis());
		}

		// Token: 0x06007462 RID: 29794
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCirclePackLayoutStrategy_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007463 RID: 29795 RVA: 0x000A83F0 File Offset: 0x000A65F0
		public new vtkCirclePackLayoutStrategy NewInstance()
		{
			vtkCirclePackLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCirclePackLayoutStrategy.vtkCirclePackLayoutStrategy_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCirclePackLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007464 RID: 29796
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCirclePackLayoutStrategy_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007465 RID: 29797 RVA: 0x000A844C File Offset: 0x000A664C
		public new static vtkCirclePackLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkCirclePackLayoutStrategy vtkCirclePackLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCirclePackLayoutStrategy.vtkCirclePackLayoutStrategy_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCirclePackLayoutStrategy = (vtkCirclePackLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCirclePackLayoutStrategy.Register(null);
				}
			}
			return vtkCirclePackLayoutStrategy;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A12 RID: 2578
		public new const string MRFullTypeName = "Kitware.VTK.vtkCirclePackLayoutStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A13 RID: 2579
		public new static readonly string MRClassNameKey = "class vtkCirclePackLayoutStrategy";
	}
}
