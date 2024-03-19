using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageReader2Collection
	/// </summary>
	/// <remarks>
	///    maintain a list of image readers
	///
	/// vtkImageReader2Collection is an object that creates and manipulates
	/// lists of objects of type vtkImageReader2 and its subclasses.
	/// </remarks>
	/// <seealso>
	///
	/// vtkCollection vtkPlaneCollection
	/// </seealso>
	// Token: 0x02000786 RID: 1926
	public class vtkImageReader2Collection : vtkCollection
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013C88 RID: 81032 RVA: 0x001BF473 File Offset: 0x001BD673
		static vtkImageReader2Collection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageReader2Collection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageReader2Collection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013C89 RID: 81033 RVA: 0x001BF49B File Offset: 0x001BD69B
		public vtkImageReader2Collection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013C8A RID: 81034
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReader2Collection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013C8B RID: 81035 RVA: 0x001BF4AC File Offset: 0x001BD6AC
		public new static vtkImageReader2Collection New()
		{
			vtkImageReader2Collection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageReader2Collection.vtkImageReader2Collection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageReader2Collection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013C8C RID: 81036 RVA: 0x001BF500 File Offset: 0x001BD700
		public vtkImageReader2Collection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageReader2Collection.vtkImageReader2Collection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013C8D RID: 81037 RVA: 0x001BF544 File Offset: 0x001BD744
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013C8E RID: 81038
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2Collection_AddItem_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Add an image reader to the list.
		/// </summary>
		// Token: 0x06013C8F RID: 81039 RVA: 0x001BF550 File Offset: 0x001BD750
		public void AddItem(vtkImageReader2 arg0)
		{
			vtkImageReader2Collection.vtkImageReader2Collection_AddItem_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06013C90 RID: 81040
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReader2Collection_GetNextItem_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the next image reader in the list.
		/// </summary>
		// Token: 0x06013C91 RID: 81041 RVA: 0x001BF580 File Offset: 0x001BD780
		public vtkImageReader2 GetNextItem()
		{
			vtkImageReader2 vtkImageReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageReader2Collection.vtkImageReader2Collection_GetNextItem_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageReader = (vtkImageReader2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageReader.Register(null);
				}
			}
			return vtkImageReader;
		}

		// Token: 0x06013C92 RID: 81042
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageReader2Collection_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013C93 RID: 81043 RVA: 0x001BF5F0 File Offset: 0x001BD7F0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageReader2Collection.vtkImageReader2Collection_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06013C94 RID: 81044
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageReader2Collection_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013C95 RID: 81045 RVA: 0x001BF610 File Offset: 0x001BD810
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageReader2Collection.vtkImageReader2Collection_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06013C96 RID: 81046
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReader2Collection_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013C97 RID: 81047 RVA: 0x001BF62C File Offset: 0x001BD82C
		public override int IsA(string type)
		{
			return vtkImageReader2Collection.vtkImageReader2Collection_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06013C98 RID: 81048
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReader2Collection_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013C99 RID: 81049 RVA: 0x001BF64C File Offset: 0x001BD84C
		public new static int IsTypeOf(string type)
		{
			return vtkImageReader2Collection.vtkImageReader2Collection_IsTypeOf_06(type);
		}

		// Token: 0x06013C9A RID: 81050
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReader2Collection_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013C9B RID: 81051 RVA: 0x001BF668 File Offset: 0x001BD868
		public new vtkImageReader2Collection NewInstance()
		{
			vtkImageReader2Collection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageReader2Collection.vtkImageReader2Collection_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageReader2Collection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013C9C RID: 81052
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReader2Collection_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013C9D RID: 81053 RVA: 0x001BF6C4 File Offset: 0x001BD8C4
		public new static vtkImageReader2Collection SafeDownCast(vtkObjectBase o)
		{
			vtkImageReader2Collection vtkImageReader2Collection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageReader2Collection.vtkImageReader2Collection_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageReader2Collection = (vtkImageReader2Collection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageReader2Collection.Register(null);
				}
			}
			return vtkImageReader2Collection;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016BE RID: 5822
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageReader2Collection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016BF RID: 5823
		public new static readonly string MRClassNameKey = "class vtkImageReader2Collection";
	}
}
