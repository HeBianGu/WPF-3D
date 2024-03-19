using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTransformCollection
	/// </summary>
	/// <remarks>
	///    maintain a list of transforms
	///
	///
	/// vtkTransformCollection is an object that creates and manipulates lists of
	/// objects of type vtkTransform.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCollection vtkTransform
	/// </seealso>
	// Token: 0x02000B11 RID: 2833
	public class vtkTransformCollection : vtkCollection
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601DC79 RID: 121977 RVA: 0x002A0DE1 File Offset: 0x0029EFE1
		static vtkTransformCollection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTransformCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransformCollection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601DC7A RID: 121978 RVA: 0x002A0E09 File Offset: 0x0029F009
		public vtkTransformCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601DC7B RID: 121979
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DC7C RID: 121980 RVA: 0x002A0E18 File Offset: 0x0029F018
		public new static vtkTransformCollection New()
		{
			vtkTransformCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransformCollection.vtkTransformCollection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransformCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DC7D RID: 121981 RVA: 0x002A0E6C File Offset: 0x0029F06C
		public vtkTransformCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTransformCollection.vtkTransformCollection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601DC7E RID: 121982 RVA: 0x002A0EB0 File Offset: 0x0029F0B0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601DC7F RID: 121983
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformCollection_AddItem_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Add a Transform to the list.
		/// </summary>
		// Token: 0x0601DC80 RID: 121984 RVA: 0x002A0EBC File Offset: 0x0029F0BC
		public void AddItem(vtkTransform arg0)
		{
			vtkTransformCollection.vtkTransformCollection_AddItem_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601DC81 RID: 121985
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformCollection_GetNextItem_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the next Transform in the list. Return nullptr when the end of the
		/// list is reached.
		/// </summary>
		// Token: 0x0601DC82 RID: 121986 RVA: 0x002A0EEC File Offset: 0x0029F0EC
		public vtkTransform GetNextItem()
		{
			vtkTransform vtkTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransformCollection.vtkTransformCollection_GetNextItem_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransform = (vtkTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransform.Register(null);
				}
			}
			return vtkTransform;
		}

		// Token: 0x0601DC83 RID: 121987
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransformCollection_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DC84 RID: 121988 RVA: 0x002A0F5C File Offset: 0x0029F15C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTransformCollection.vtkTransformCollection_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601DC85 RID: 121989
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransformCollection_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DC86 RID: 121990 RVA: 0x002A0F7C File Offset: 0x0029F17C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTransformCollection.vtkTransformCollection_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601DC87 RID: 121991
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransformCollection_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DC88 RID: 121992 RVA: 0x002A0F98 File Offset: 0x0029F198
		public override int IsA(string type)
		{
			return vtkTransformCollection.vtkTransformCollection_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601DC89 RID: 121993
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransformCollection_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DC8A RID: 121994 RVA: 0x002A0FB8 File Offset: 0x0029F1B8
		public new static int IsTypeOf(string type)
		{
			return vtkTransformCollection.vtkTransformCollection_IsTypeOf_06(type);
		}

		// Token: 0x0601DC8B RID: 121995
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformCollection_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DC8C RID: 121996 RVA: 0x002A0FD4 File Offset: 0x0029F1D4
		public new vtkTransformCollection NewInstance()
		{
			vtkTransformCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransformCollection.vtkTransformCollection_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransformCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DC8D RID: 121997
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformCollection_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DC8E RID: 121998 RVA: 0x002A1030 File Offset: 0x0029F230
		public new static vtkTransformCollection SafeDownCast(vtkObjectBase o)
		{
			vtkTransformCollection vtkTransformCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransformCollection.vtkTransformCollection_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransformCollection = (vtkTransformCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransformCollection.Register(null);
				}
			}
			return vtkTransformCollection;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F53 RID: 8019
		public new const string MRFullTypeName = "Kitware.VTK.vtkTransformCollection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F54 RID: 8020
		public new static readonly string MRClassNameKey = "class vtkTransformCollection";
	}
}
