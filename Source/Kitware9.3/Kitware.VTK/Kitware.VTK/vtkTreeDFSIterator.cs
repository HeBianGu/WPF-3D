using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTreeDFSIterator
	/// </summary>
	/// <remarks>
	///    depth first iterator through a vtkGraph
	///
	///
	/// vtkTreeDFSIterator performs a depth first search traversal of a tree.
	///
	/// First, you must set the tree on which you are going to iterate, and then
	/// optionally set the starting vertex and mode. The mode is either
	/// DISCOVER (default), in which case vertices are visited as they are first
	/// reached, or FINISH, in which case vertices are visited when they are
	/// done, i.e. all adjacent vertices have been discovered already.
	///
	/// After setting up the iterator, the normal mode of operation is to
	/// set up a &lt;code&gt;while(iter-&gt;HasNext())&lt;/code&gt; loop, with the statement
	/// &lt;code&gt;vtkIdType vertex = iter-&gt;Next()&lt;/code&gt; inside the loop.
	/// </remarks>
	// Token: 0x02000AD7 RID: 2775
	public class vtkTreeDFSIterator : vtkTreeIterator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D3AE RID: 119726 RVA: 0x00293917 File Offset: 0x00291B17
		static vtkTreeDFSIterator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTreeDFSIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeDFSIterator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D3AF RID: 119727 RVA: 0x0029393F File Offset: 0x00291B3F
		public vtkTreeDFSIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D3B0 RID: 119728
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeDFSIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D3B1 RID: 119729 RVA: 0x00293950 File Offset: 0x00291B50
		public new static vtkTreeDFSIterator New()
		{
			vtkTreeDFSIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeDFSIterator.vtkTreeDFSIterator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeDFSIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D3B2 RID: 119730 RVA: 0x002939A4 File Offset: 0x00291BA4
		public vtkTreeDFSIterator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTreeDFSIterator.vtkTreeDFSIterator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D3B3 RID: 119731 RVA: 0x002939E8 File Offset: 0x00291BE8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D3B4 RID: 119732
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeDFSIterator_GetMode_01(HandleRef pThis);

		/// <summary>
		/// Set the visit mode of the iterator.  Mode can be
		/// DISCOVER (0): Order by discovery time
		/// FINISH   (1): Order by finish time
		/// Default is DISCOVER.
		/// Use DISCOVER for top-down algorithms where parents need to be processed before children.
		/// Use FINISH for bottom-up algorithms where children need to be processed before parents.
		/// </summary>
		// Token: 0x0601D3B5 RID: 119733 RVA: 0x002939F4 File Offset: 0x00291BF4
		public virtual int GetMode()
		{
			return vtkTreeDFSIterator.vtkTreeDFSIterator_GetMode_01(base.GetCppThis());
		}

		// Token: 0x0601D3B6 RID: 119734
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeDFSIterator_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D3B7 RID: 119735 RVA: 0x00293A14 File Offset: 0x00291C14
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTreeDFSIterator.vtkTreeDFSIterator_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601D3B8 RID: 119736
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeDFSIterator_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D3B9 RID: 119737 RVA: 0x00293A34 File Offset: 0x00291C34
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTreeDFSIterator.vtkTreeDFSIterator_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601D3BA RID: 119738
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeDFSIterator_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D3BB RID: 119739 RVA: 0x00293A50 File Offset: 0x00291C50
		public override int IsA(string type)
		{
			return vtkTreeDFSIterator.vtkTreeDFSIterator_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601D3BC RID: 119740
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeDFSIterator_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D3BD RID: 119741 RVA: 0x00293A70 File Offset: 0x00291C70
		public new static int IsTypeOf(string type)
		{
			return vtkTreeDFSIterator.vtkTreeDFSIterator_IsTypeOf_05(type);
		}

		// Token: 0x0601D3BE RID: 119742
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeDFSIterator_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D3BF RID: 119743 RVA: 0x00293A8C File Offset: 0x00291C8C
		public new vtkTreeDFSIterator NewInstance()
		{
			vtkTreeDFSIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeDFSIterator.vtkTreeDFSIterator_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeDFSIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D3C0 RID: 119744
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeDFSIterator_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D3C1 RID: 119745 RVA: 0x00293AE8 File Offset: 0x00291CE8
		public new static vtkTreeDFSIterator SafeDownCast(vtkObjectBase o)
		{
			vtkTreeDFSIterator vtkTreeDFSIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeDFSIterator.vtkTreeDFSIterator_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeDFSIterator = (vtkTreeDFSIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeDFSIterator.Register(null);
				}
			}
			return vtkTreeDFSIterator;
		}

		// Token: 0x0601D3C2 RID: 119746
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeDFSIterator_SetMode_09(HandleRef pThis, int mode);

		/// <summary>
		/// Set the visit mode of the iterator.  Mode can be
		/// DISCOVER (0): Order by discovery time
		/// FINISH   (1): Order by finish time
		/// Default is DISCOVER.
		/// Use DISCOVER for top-down algorithms where parents need to be processed before children.
		/// Use FINISH for bottom-up algorithms where children need to be processed before parents.
		/// </summary>
		// Token: 0x0601D3C3 RID: 119747 RVA: 0x00293B67 File Offset: 0x00291D67
		public void SetMode(int mode)
		{
			vtkTreeDFSIterator.vtkTreeDFSIterator_SetMode_09(base.GetCppThis(), mode);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001ED4 RID: 7892
		public new const string MRFullTypeName = "Kitware.VTK.vtkTreeDFSIterator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001ED5 RID: 7893
		public new static readonly string MRClassNameKey = "class vtkTreeDFSIterator";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000AD8 RID: 2776
		public enum ModeType
		{
			/// <summary>enum member</summary>
			// Token: 0x04001ED7 RID: 7895
			DISCOVER,
			/// <summary>enum member</summary>
			// Token: 0x04001ED8 RID: 7896
			FINISH
		}
	}
}
