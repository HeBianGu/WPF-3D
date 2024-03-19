using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHeap
	/// </summary>
	/// <remarks>
	///    replacement for malloc/free and new/delete
	///
	/// This class is a replacement for malloc/free and new/delete for software
	/// that has inherent memory leak or performance problems. For example,
	/// external software such as the PLY library (vtkPLY) and VRML importer
	/// (vtkVRMLImporter) are often written with lots of malloc() calls but
	/// without the corresponding free() invocations. The class
	/// vtkOrderedTriangulator may create and delete millions of new/delete calls.
	/// This class allows the overloading of the C++ new operator (or other memory
	/// allocation requests) by using the method AllocateMemory(). Memory is
	/// deleted with an invocation of CleanAll() (which deletes ALL memory; any
	/// given memory allocation cannot be deleted). Note: a block size can be used
	/// to control the size of each memory allocation. Requests for memory are
	/// fulfilled from the block until the block runs out, then a new block is
	/// created.
	///
	/// @warning
	/// Do not use this class as a general replacement for system memory
	/// allocation.  This class should be used only as a last resort if memory
	/// leaks cannot be tracked down and eliminated by conventional means. Also,
	/// deleting memory from vtkHeap is not supported. Only the deletion of
	/// the entire heap is. (A Reset() method allows you to reuse previously
	/// allocated memory.)
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkVRMLImporter vtkPLY vtkOrderedTriangulator
	/// </seealso>
	// Token: 0x02000B03 RID: 2819
	public class vtkHeap : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601DA0E RID: 121358 RVA: 0x0029D51B File Offset: 0x0029B71B
		static vtkHeap()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHeap.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHeap"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601DA0F RID: 121359 RVA: 0x0029D543 File Offset: 0x0029B743
		public vtkHeap(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601DA10 RID: 121360
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHeap_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DA11 RID: 121361 RVA: 0x0029D554 File Offset: 0x0029B754
		public new static vtkHeap New()
		{
			vtkHeap result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHeap.vtkHeap_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHeap)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DA12 RID: 121362 RVA: 0x0029D5A8 File Offset: 0x0029B7A8
		public vtkHeap() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkHeap.vtkHeap_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601DA13 RID: 121363 RVA: 0x0029D5EC File Offset: 0x0029B7EC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601DA14 RID: 121364
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHeap_AllocateMemory_01(HandleRef pThis, ulong n);

		/// <summary>
		/// Allocate the memory requested.
		/// </summary>
		// Token: 0x0601DA15 RID: 121365 RVA: 0x0029D5F8 File Offset: 0x0029B7F8
		public IntPtr AllocateMemory(ulong n)
		{
			return vtkHeap.vtkHeap_AllocateMemory_01(base.GetCppThis(), n);
		}

		// Token: 0x0601DA16 RID: 121366
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkHeap_GetBlockSize_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the size at which blocks are allocated. If a memory
		/// request is bigger than the block size, then that size
		/// will be allocated.
		/// </summary>
		// Token: 0x0601DA17 RID: 121367 RVA: 0x0029D618 File Offset: 0x0029B818
		public virtual ulong GetBlockSize()
		{
			return vtkHeap.vtkHeap_GetBlockSize_02(base.GetCppThis());
		}

		// Token: 0x0601DA18 RID: 121368
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHeap_GetNumberOfAllocations_03(HandleRef pThis);

		/// <summary>
		/// Get the number of allocations thus far.
		/// </summary>
		// Token: 0x0601DA19 RID: 121369 RVA: 0x0029D638 File Offset: 0x0029B838
		public virtual int GetNumberOfAllocations()
		{
			return vtkHeap.vtkHeap_GetNumberOfAllocations_03(base.GetCppThis());
		}

		// Token: 0x0601DA1A RID: 121370
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHeap_GetNumberOfBlocks_04(HandleRef pThis);

		/// <summary>
		/// Get the number of allocations thus far.
		/// </summary>
		// Token: 0x0601DA1B RID: 121371 RVA: 0x0029D658 File Offset: 0x0029B858
		public virtual int GetNumberOfBlocks()
		{
			return vtkHeap.vtkHeap_GetNumberOfBlocks_04(base.GetCppThis());
		}

		// Token: 0x0601DA1C RID: 121372
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHeap_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DA1D RID: 121373 RVA: 0x0029D678 File Offset: 0x0029B878
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHeap.vtkHeap_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601DA1E RID: 121374
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHeap_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DA1F RID: 121375 RVA: 0x0029D698 File Offset: 0x0029B898
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHeap.vtkHeap_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601DA20 RID: 121376
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHeap_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DA21 RID: 121377 RVA: 0x0029D6B4 File Offset: 0x0029B8B4
		public override int IsA(string type)
		{
			return vtkHeap.vtkHeap_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601DA22 RID: 121378
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHeap_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DA23 RID: 121379 RVA: 0x0029D6D4 File Offset: 0x0029B8D4
		public new static int IsTypeOf(string type)
		{
			return vtkHeap.vtkHeap_IsTypeOf_08(type);
		}

		// Token: 0x0601DA24 RID: 121380
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHeap_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DA25 RID: 121381 RVA: 0x0029D6F0 File Offset: 0x0029B8F0
		public new vtkHeap NewInstance()
		{
			vtkHeap result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHeap.vtkHeap_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHeap)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DA26 RID: 121382
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHeap_Reset_11(HandleRef pThis);

		/// <summary>
		/// This methods resets the current allocation location
		/// back to the beginning of the heap. This allows
		/// reuse of previously allocated memory which may be
		/// beneficial to performance in many cases.
		/// </summary>
		// Token: 0x0601DA27 RID: 121383 RVA: 0x0029D74A File Offset: 0x0029B94A
		public void Reset()
		{
			vtkHeap.vtkHeap_Reset_11(base.GetCppThis());
		}

		// Token: 0x0601DA28 RID: 121384
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHeap_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DA29 RID: 121385 RVA: 0x0029D75C File Offset: 0x0029B95C
		public new static vtkHeap SafeDownCast(vtkObjectBase o)
		{
			vtkHeap vtkHeap = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHeap.vtkHeap_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHeap = (vtkHeap)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHeap.Register(null);
				}
			}
			return vtkHeap;
		}

		// Token: 0x0601DA2A RID: 121386
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHeap_SetBlockSize_13(HandleRef pThis, ulong arg0);

		/// <summary>
		/// Set/Get the size at which blocks are allocated. If a memory
		/// request is bigger than the block size, then that size
		/// will be allocated.
		/// </summary>
		// Token: 0x0601DA2B RID: 121387 RVA: 0x0029D7DB File Offset: 0x0029B9DB
		public virtual void SetBlockSize(ulong arg0)
		{
			vtkHeap.vtkHeap_SetBlockSize_13(base.GetCppThis(), arg0);
		}

		// Token: 0x0601DA2C RID: 121388
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHeap_StringDup_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string str);

		/// <summary>
		/// Convenience method performs string duplication.
		/// </summary>
		// Token: 0x0601DA2D RID: 121389 RVA: 0x0029D7EC File Offset: 0x0029B9EC
		public string StringDup(string str)
		{
			string s = Marshal.PtrToStringAnsi(vtkHeap.vtkHeap_StringDup_14(base.GetCppThis(), str));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F37 RID: 7991
		public new const string MRFullTypeName = "Kitware.VTK.vtkHeap";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F38 RID: 7992
		public new static readonly string MRClassNameKey = "class vtkHeap";
	}
}
