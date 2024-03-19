using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRenderPassCollection
	/// </summary>
	/// <remarks>
	///    an ordered list of RenderPasses
	///
	/// vtkRenderPassCollection represents a list of RenderPasses
	/// (i.e., vtkRenderPass and subclasses) and provides methods to manipulate the
	/// list. The list is ordered and duplicate entries are not prevented.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderPass vtkCollection
	/// </seealso>
	// Token: 0x020005E3 RID: 1507
	public class vtkRenderPassCollection : vtkCollection
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060106CF RID: 67279 RVA: 0x0016E467 File Offset: 0x0016C667
		static vtkRenderPassCollection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRenderPassCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderPassCollection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060106D0 RID: 67280 RVA: 0x0016E48F File Offset: 0x0016C68F
		public vtkRenderPassCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060106D1 RID: 67281
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderPassCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060106D2 RID: 67282 RVA: 0x0016E4A0 File Offset: 0x0016C6A0
		public new static vtkRenderPassCollection New()
		{
			vtkRenderPassCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderPassCollection.vtkRenderPassCollection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderPassCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060106D3 RID: 67283 RVA: 0x0016E4F4 File Offset: 0x0016C6F4
		public vtkRenderPassCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRenderPassCollection.vtkRenderPassCollection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060106D4 RID: 67284 RVA: 0x0016E538 File Offset: 0x0016C738
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060106D5 RID: 67285
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderPassCollection_AddItem_01(HandleRef pThis, HandleRef pass);

		/// <summary>
		/// Add an RenderPass to the bottom of the list.
		/// </summary>
		// Token: 0x060106D6 RID: 67286 RVA: 0x0016E544 File Offset: 0x0016C744
		public void AddItem(vtkRenderPass pass)
		{
			vtkRenderPassCollection.vtkRenderPassCollection_AddItem_01(base.GetCppThis(), (pass == null) ? default(HandleRef) : pass.GetCppThis());
		}

		// Token: 0x060106D7 RID: 67287
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderPassCollection_GetLastRenderPass_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the last RenderPass in the list.
		/// </summary>
		// Token: 0x060106D8 RID: 67288 RVA: 0x0016E574 File Offset: 0x0016C774
		public vtkRenderPass GetLastRenderPass()
		{
			vtkRenderPass vtkRenderPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderPassCollection.vtkRenderPassCollection_GetLastRenderPass_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderPass = (vtkRenderPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderPass.Register(null);
				}
			}
			return vtkRenderPass;
		}

		// Token: 0x060106D9 RID: 67289
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderPassCollection_GetNextRenderPass_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the next RenderPass in the list.
		/// </summary>
		// Token: 0x060106DA RID: 67290 RVA: 0x0016E5E4 File Offset: 0x0016C7E4
		public vtkRenderPass GetNextRenderPass()
		{
			vtkRenderPass vtkRenderPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderPassCollection.vtkRenderPassCollection_GetNextRenderPass_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderPass = (vtkRenderPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderPass.Register(null);
				}
			}
			return vtkRenderPass;
		}

		// Token: 0x060106DB RID: 67291
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderPassCollection_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060106DC RID: 67292 RVA: 0x0016E654 File Offset: 0x0016C854
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRenderPassCollection.vtkRenderPassCollection_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060106DD RID: 67293
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderPassCollection_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060106DE RID: 67294 RVA: 0x0016E674 File Offset: 0x0016C874
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRenderPassCollection.vtkRenderPassCollection_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060106DF RID: 67295
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderPassCollection_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060106E0 RID: 67296 RVA: 0x0016E690 File Offset: 0x0016C890
		public override int IsA(string type)
		{
			return vtkRenderPassCollection.vtkRenderPassCollection_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060106E1 RID: 67297
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderPassCollection_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060106E2 RID: 67298 RVA: 0x0016E6B0 File Offset: 0x0016C8B0
		public new static int IsTypeOf(string type)
		{
			return vtkRenderPassCollection.vtkRenderPassCollection_IsTypeOf_07(type);
		}

		// Token: 0x060106E3 RID: 67299
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderPassCollection_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060106E4 RID: 67300 RVA: 0x0016E6CC File Offset: 0x0016C8CC
		public new vtkRenderPassCollection NewInstance()
		{
			vtkRenderPassCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderPassCollection.vtkRenderPassCollection_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderPassCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060106E5 RID: 67301
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderPassCollection_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060106E6 RID: 67302 RVA: 0x0016E728 File Offset: 0x0016C928
		public new static vtkRenderPassCollection SafeDownCast(vtkObjectBase o)
		{
			vtkRenderPassCollection vtkRenderPassCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderPassCollection.vtkRenderPassCollection_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderPassCollection = (vtkRenderPassCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderPassCollection.Register(null);
				}
			}
			return vtkRenderPassCollection;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001312 RID: 4882
		public new const string MRFullTypeName = "Kitware.VTK.vtkRenderPassCollection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001313 RID: 4883
		public new static readonly string MRClassNameKey = "class vtkRenderPassCollection";
	}
}
