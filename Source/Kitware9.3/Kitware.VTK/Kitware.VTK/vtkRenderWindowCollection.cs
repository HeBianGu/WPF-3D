using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRenderWindowCollection
	/// </summary>
	/// <remarks>
	///    an ordered list of RenderWindows
	///
	/// vtkRenderWindowCollection represents and provides methods to manipulate a
	/// list of RenderWindows. The list is ordered and duplicate entries are
	/// not prevented.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderWindow vtkCollection
	/// </seealso>
	// Token: 0x020007FA RID: 2042
	public class vtkRenderWindowCollection : vtkCollection
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014FB6 RID: 85942 RVA: 0x001DAFCB File Offset: 0x001D91CB
		static vtkRenderWindowCollection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRenderWindowCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderWindowCollection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014FB7 RID: 85943 RVA: 0x001DAFF3 File Offset: 0x001D91F3
		public vtkRenderWindowCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014FB8 RID: 85944
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014FB9 RID: 85945 RVA: 0x001DB004 File Offset: 0x001D9204
		public new static vtkRenderWindowCollection New()
		{
			vtkRenderWindowCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderWindowCollection.vtkRenderWindowCollection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderWindowCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014FBA RID: 85946 RVA: 0x001DB058 File Offset: 0x001D9258
		public vtkRenderWindowCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRenderWindowCollection.vtkRenderWindowCollection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014FBB RID: 85947 RVA: 0x001DB09C File Offset: 0x001D929C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014FBC RID: 85948
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowCollection_AddItem_01(HandleRef pThis, HandleRef a);

		/// <summary>
		/// Add a RenderWindow to the bottom of the list.
		/// </summary>
		// Token: 0x06014FBD RID: 85949 RVA: 0x001DB0A8 File Offset: 0x001D92A8
		public void AddItem(vtkRenderWindow a)
		{
			vtkRenderWindowCollection.vtkRenderWindowCollection_AddItem_01(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		// Token: 0x06014FBE RID: 85950
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowCollection_GetNextItem_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the next RenderWindow in the list. Return NULL when at the end of the
		/// list.
		/// </summary>
		// Token: 0x06014FBF RID: 85951 RVA: 0x001DB0D8 File Offset: 0x001D92D8
		public vtkRenderWindow GetNextItem()
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderWindowCollection.vtkRenderWindowCollection_GetNextItem_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindow = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindow.Register(null);
				}
			}
			return vtkRenderWindow;
		}

		// Token: 0x06014FC0 RID: 85952
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderWindowCollection_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014FC1 RID: 85953 RVA: 0x001DB148 File Offset: 0x001D9348
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRenderWindowCollection.vtkRenderWindowCollection_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06014FC2 RID: 85954
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderWindowCollection_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014FC3 RID: 85955 RVA: 0x001DB168 File Offset: 0x001D9368
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRenderWindowCollection.vtkRenderWindowCollection_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06014FC4 RID: 85956
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindowCollection_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014FC5 RID: 85957 RVA: 0x001DB184 File Offset: 0x001D9384
		public override int IsA(string type)
		{
			return vtkRenderWindowCollection.vtkRenderWindowCollection_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06014FC6 RID: 85958
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindowCollection_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014FC7 RID: 85959 RVA: 0x001DB1A4 File Offset: 0x001D93A4
		public new static int IsTypeOf(string type)
		{
			return vtkRenderWindowCollection.vtkRenderWindowCollection_IsTypeOf_06(type);
		}

		// Token: 0x06014FC8 RID: 85960
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowCollection_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014FC9 RID: 85961 RVA: 0x001DB1C0 File Offset: 0x001D93C0
		public new vtkRenderWindowCollection NewInstance()
		{
			vtkRenderWindowCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderWindowCollection.vtkRenderWindowCollection_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderWindowCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014FCA RID: 85962
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowCollection_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014FCB RID: 85963 RVA: 0x001DB21C File Offset: 0x001D941C
		public new static vtkRenderWindowCollection SafeDownCast(vtkObjectBase o)
		{
			vtkRenderWindowCollection vtkRenderWindowCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderWindowCollection.vtkRenderWindowCollection_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindowCollection = (vtkRenderWindowCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindowCollection.Register(null);
				}
			}
			return vtkRenderWindowCollection;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001838 RID: 6200
		public new const string MRFullTypeName = "Kitware.VTK.vtkRenderWindowCollection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001839 RID: 6201
		public new static readonly string MRClassNameKey = "class vtkRenderWindowCollection";
	}
}
