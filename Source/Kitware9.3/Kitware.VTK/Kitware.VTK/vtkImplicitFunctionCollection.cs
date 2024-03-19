using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImplicitFunctionCollection
	/// </summary>
	/// <remarks>
	///    maintain a list of implicit functions
	///
	/// vtkImplicitFunctionCollection is an object that creates and manipulates
	/// lists of objects of type vtkImplicitFunction.
	/// </remarks>
	/// <seealso>
	///
	/// vtkCollection vtkPlaneCollection
	/// </seealso>
	// Token: 0x02000A68 RID: 2664
	public class vtkImplicitFunctionCollection : vtkCollection
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601BE4B RID: 114251 RVA: 0x00271261 File Offset: 0x0026F461
		static vtkImplicitFunctionCollection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitFunctionCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitFunctionCollection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601BE4C RID: 114252 RVA: 0x00271289 File Offset: 0x0026F489
		public vtkImplicitFunctionCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601BE4D RID: 114253
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitFunctionCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BE4E RID: 114254 RVA: 0x00271298 File Offset: 0x0026F498
		public new static vtkImplicitFunctionCollection New()
		{
			vtkImplicitFunctionCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitFunctionCollection.vtkImplicitFunctionCollection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitFunctionCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BE4F RID: 114255 RVA: 0x002712EC File Offset: 0x0026F4EC
		public vtkImplicitFunctionCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImplicitFunctionCollection.vtkImplicitFunctionCollection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601BE50 RID: 114256 RVA: 0x00271330 File Offset: 0x0026F530
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601BE51 RID: 114257
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitFunctionCollection_AddItem_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Add an implicit function to the list.
		/// </summary>
		// Token: 0x0601BE52 RID: 114258 RVA: 0x0027133C File Offset: 0x0026F53C
		public void AddItem(vtkImplicitFunction arg0)
		{
			vtkImplicitFunctionCollection.vtkImplicitFunctionCollection_AddItem_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601BE53 RID: 114259
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitFunctionCollection_GetNextItem_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the next implicit function in the list.
		/// </summary>
		// Token: 0x0601BE54 RID: 114260 RVA: 0x0027136C File Offset: 0x0026F56C
		public vtkImplicitFunction GetNextItem()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitFunctionCollection.vtkImplicitFunctionCollection_GetNextItem_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitFunction = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitFunction.Register(null);
				}
			}
			return vtkImplicitFunction;
		}

		// Token: 0x0601BE55 RID: 114261
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitFunctionCollection_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BE56 RID: 114262 RVA: 0x002713DC File Offset: 0x0026F5DC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImplicitFunctionCollection.vtkImplicitFunctionCollection_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601BE57 RID: 114263
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitFunctionCollection_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BE58 RID: 114264 RVA: 0x002713FC File Offset: 0x0026F5FC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImplicitFunctionCollection.vtkImplicitFunctionCollection_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601BE59 RID: 114265
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitFunctionCollection_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BE5A RID: 114266 RVA: 0x00271418 File Offset: 0x0026F618
		public override int IsA(string type)
		{
			return vtkImplicitFunctionCollection.vtkImplicitFunctionCollection_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601BE5B RID: 114267
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitFunctionCollection_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BE5C RID: 114268 RVA: 0x00271438 File Offset: 0x0026F638
		public new static int IsTypeOf(string type)
		{
			return vtkImplicitFunctionCollection.vtkImplicitFunctionCollection_IsTypeOf_06(type);
		}

		// Token: 0x0601BE5D RID: 114269
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitFunctionCollection_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BE5E RID: 114270 RVA: 0x00271454 File Offset: 0x0026F654
		public new vtkImplicitFunctionCollection NewInstance()
		{
			vtkImplicitFunctionCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitFunctionCollection.vtkImplicitFunctionCollection_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitFunctionCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601BE5F RID: 114271
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitFunctionCollection_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BE60 RID: 114272 RVA: 0x002714B0 File Offset: 0x0026F6B0
		public new static vtkImplicitFunctionCollection SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitFunctionCollection vtkImplicitFunctionCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitFunctionCollection.vtkImplicitFunctionCollection_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitFunctionCollection = (vtkImplicitFunctionCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitFunctionCollection.Register(null);
				}
			}
			return vtkImplicitFunctionCollection;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DC7 RID: 7623
		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitFunctionCollection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DC8 RID: 7624
		public new static readonly string MRClassNameKey = "class vtkImplicitFunctionCollection";
	}
}
