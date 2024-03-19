using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTreeBFSIterator
	/// </summary>
	/// <remarks>
	///    breadth first search iterator through a vtkTree
	///
	///
	/// vtkTreeBFSIterator performs a breadth first search traversal of a tree.
	///
	/// After setting up the iterator, the normal mode of operation is to
	/// set up a &lt;code&gt;while(iter-&gt;HasNext())&lt;/code&gt; loop, with the statement
	/// &lt;code&gt;vtkIdType vertex = iter-&gt;Next()&lt;/code&gt; inside the loop.
	///
	/// @par Thanks:
	/// Thanks to David Doria for submitting this class.
	/// </remarks>
	// Token: 0x02000AD6 RID: 2774
	public class vtkTreeBFSIterator : vtkTreeIterator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D39C RID: 119708 RVA: 0x002936E7 File Offset: 0x002918E7
		static vtkTreeBFSIterator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTreeBFSIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeBFSIterator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D39D RID: 119709 RVA: 0x0029370F File Offset: 0x0029190F
		public vtkTreeBFSIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D39E RID: 119710
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeBFSIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D39F RID: 119711 RVA: 0x00293720 File Offset: 0x00291920
		public new static vtkTreeBFSIterator New()
		{
			vtkTreeBFSIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeBFSIterator.vtkTreeBFSIterator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeBFSIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D3A0 RID: 119712 RVA: 0x00293774 File Offset: 0x00291974
		public vtkTreeBFSIterator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTreeBFSIterator.vtkTreeBFSIterator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D3A1 RID: 119713 RVA: 0x002937B8 File Offset: 0x002919B8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D3A2 RID: 119714
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeBFSIterator_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D3A3 RID: 119715 RVA: 0x002937C4 File Offset: 0x002919C4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTreeBFSIterator.vtkTreeBFSIterator_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601D3A4 RID: 119716
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeBFSIterator_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D3A5 RID: 119717 RVA: 0x002937E4 File Offset: 0x002919E4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTreeBFSIterator.vtkTreeBFSIterator_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601D3A6 RID: 119718
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeBFSIterator_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D3A7 RID: 119719 RVA: 0x00293800 File Offset: 0x00291A00
		public override int IsA(string type)
		{
			return vtkTreeBFSIterator.vtkTreeBFSIterator_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601D3A8 RID: 119720
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeBFSIterator_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D3A9 RID: 119721 RVA: 0x00293820 File Offset: 0x00291A20
		public new static int IsTypeOf(string type)
		{
			return vtkTreeBFSIterator.vtkTreeBFSIterator_IsTypeOf_04(type);
		}

		// Token: 0x0601D3AA RID: 119722
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeBFSIterator_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D3AB RID: 119723 RVA: 0x0029383C File Offset: 0x00291A3C
		public new vtkTreeBFSIterator NewInstance()
		{
			vtkTreeBFSIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeBFSIterator.vtkTreeBFSIterator_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeBFSIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D3AC RID: 119724
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeBFSIterator_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D3AD RID: 119725 RVA: 0x00293898 File Offset: 0x00291A98
		public new static vtkTreeBFSIterator SafeDownCast(vtkObjectBase o)
		{
			vtkTreeBFSIterator vtkTreeBFSIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeBFSIterator.vtkTreeBFSIterator_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeBFSIterator = (vtkTreeBFSIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeBFSIterator.Register(null);
				}
			}
			return vtkTreeBFSIterator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001ED2 RID: 7890
		public new const string MRFullTypeName = "Kitware.VTK.vtkTreeBFSIterator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001ED3 RID: 7891
		public new static readonly string MRClassNameKey = "class vtkTreeBFSIterator";
	}
}
