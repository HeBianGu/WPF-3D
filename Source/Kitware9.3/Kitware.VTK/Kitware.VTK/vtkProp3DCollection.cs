using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkProp3DCollection
	/// </summary>
	/// <remarks>
	///    an ordered list of 3D props
	///
	/// vtkProp3DCollection represents and provides methods to manipulate a list of
	/// 3D props (i.e., vtkProp3D and subclasses). The list is ordered and
	/// duplicate entries are not prevented.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkProp3D vtkCollection
	/// </seealso>
	// Token: 0x020007F7 RID: 2039
	public class vtkProp3DCollection : vtkPropCollection
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014F20 RID: 85792 RVA: 0x001DA193 File Offset: 0x001D8393
		static vtkProp3DCollection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProp3DCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProp3DCollection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014F21 RID: 85793 RVA: 0x001DA1BB File Offset: 0x001D83BB
		public vtkProp3DCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014F22 RID: 85794
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3DCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014F23 RID: 85795 RVA: 0x001DA1CC File Offset: 0x001D83CC
		public new static vtkProp3DCollection New()
		{
			vtkProp3DCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp3DCollection.vtkProp3DCollection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProp3DCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014F24 RID: 85796 RVA: 0x001DA220 File Offset: 0x001D8420
		public vtkProp3DCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkProp3DCollection.vtkProp3DCollection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014F25 RID: 85797 RVA: 0x001DA264 File Offset: 0x001D8464
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014F26 RID: 85798
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DCollection_AddItem_01(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Add an actor to the bottom of the list.
		/// </summary>
		// Token: 0x06014F27 RID: 85799 RVA: 0x001DA270 File Offset: 0x001D8470
		public void AddItem(vtkProp3D p)
		{
			vtkProp3DCollection.vtkProp3DCollection_AddItem_01(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x06014F28 RID: 85800
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3DCollection_GetLastProp3D_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the last actor in the list.
		/// </summary>
		// Token: 0x06014F29 RID: 85801 RVA: 0x001DA2A0 File Offset: 0x001D84A0
		public vtkProp3D GetLastProp3D()
		{
			vtkProp3D vtkProp3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp3DCollection.vtkProp3DCollection_GetLastProp3D_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp3D = (vtkProp3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp3D.Register(null);
				}
			}
			return vtkProp3D;
		}

		// Token: 0x06014F2A RID: 85802
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3DCollection_GetNextProp3D_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the next actor in the list.
		/// </summary>
		// Token: 0x06014F2B RID: 85803 RVA: 0x001DA310 File Offset: 0x001D8510
		public vtkProp3D GetNextProp3D()
		{
			vtkProp3D vtkProp3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp3DCollection.vtkProp3DCollection_GetNextProp3D_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp3D = (vtkProp3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp3D.Register(null);
				}
			}
			return vtkProp3D;
		}

		// Token: 0x06014F2C RID: 85804
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProp3DCollection_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014F2D RID: 85805 RVA: 0x001DA380 File Offset: 0x001D8580
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkProp3DCollection.vtkProp3DCollection_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06014F2E RID: 85806
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProp3DCollection_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014F2F RID: 85807 RVA: 0x001DA3A0 File Offset: 0x001D85A0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkProp3DCollection.vtkProp3DCollection_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06014F30 RID: 85808
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp3DCollection_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014F31 RID: 85809 RVA: 0x001DA3BC File Offset: 0x001D85BC
		public override int IsA(string type)
		{
			return vtkProp3DCollection.vtkProp3DCollection_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06014F32 RID: 85810
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp3DCollection_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014F33 RID: 85811 RVA: 0x001DA3DC File Offset: 0x001D85DC
		public new static int IsTypeOf(string type)
		{
			return vtkProp3DCollection.vtkProp3DCollection_IsTypeOf_07(type);
		}

		// Token: 0x06014F34 RID: 85812
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3DCollection_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014F35 RID: 85813 RVA: 0x001DA3F8 File Offset: 0x001D85F8
		public new vtkProp3DCollection NewInstance()
		{
			vtkProp3DCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp3DCollection.vtkProp3DCollection_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProp3DCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014F36 RID: 85814
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3DCollection_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014F37 RID: 85815 RVA: 0x001DA454 File Offset: 0x001D8654
		public new static vtkProp3DCollection SafeDownCast(vtkObjectBase o)
		{
			vtkProp3DCollection vtkProp3DCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp3DCollection.vtkProp3DCollection_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp3DCollection = (vtkProp3DCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp3DCollection.Register(null);
				}
			}
			return vtkProp3DCollection;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001832 RID: 6194
		public new const string MRFullTypeName = "Kitware.VTK.vtkProp3DCollection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001833 RID: 6195
		public new static readonly string MRClassNameKey = "class vtkProp3DCollection";
	}
}
