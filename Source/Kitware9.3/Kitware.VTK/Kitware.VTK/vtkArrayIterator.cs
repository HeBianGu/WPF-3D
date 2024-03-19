using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkArrayIterator
	/// </summary>
	/// <remarks>
	///    Abstract superclass to iterate over elements
	/// in an vtkAbstractArray.
	///
	///
	/// vtkArrayIterator is used to iterate over elements in any
	/// vtkAbstractArray subclass.  The vtkArrayIteratorTemplateMacro is used
	/// to centralize the set of types supported by Execute methods.  It also
	/// avoids duplication of long switch statement case lists.
	///
	/// Note that in this macro VTK_TT is defined to be the type of the
	/// iterator for the given type of array. One must include the
	/// vtkArrayIteratorIncludes.h header file to provide for extending of
	/// this macro by addition of new iterators.
	///
	/// Example usage:
	/// <code>
	/// vtkArrayIter* iter = array-&gt;NewIterator();
	/// switch(array-&gt;GetDataType())
	///   {
	///   vtkArrayIteratorTemplateMacro(myFunc(static_cast&lt;VTK_TT*&gt;(iter), arg2));
	///   }
	/// iter-&gt;Delete();
	/// </code>
	/// </remarks>
	// Token: 0x02000B40 RID: 2880
	public abstract class vtkArrayIterator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E1EB RID: 123371 RVA: 0x002A9BD8 File Offset: 0x002A7DD8
		static vtkArrayIterator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkArrayIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkArrayIterator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E1EC RID: 123372 RVA: 0x002A9C00 File Offset: 0x002A7E00
		public vtkArrayIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E1ED RID: 123373 RVA: 0x002A9C0E File Offset: 0x002A7E0E
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E1EE RID: 123374
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayIterator_GetDataType_01(HandleRef pThis);

		/// <summary>
		/// Get the data type from the underlying array. Returns 0 if
		/// no underlying array is present.
		/// </summary>
		// Token: 0x0601E1EF RID: 123375 RVA: 0x002A9C1C File Offset: 0x002A7E1C
		public virtual int GetDataType()
		{
			return vtkArrayIterator.vtkArrayIterator_GetDataType_01(base.GetCppThis());
		}

		// Token: 0x0601E1F0 RID: 123376
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArrayIterator_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E1F1 RID: 123377 RVA: 0x002A9C3C File Offset: 0x002A7E3C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkArrayIterator.vtkArrayIterator_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601E1F2 RID: 123378
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArrayIterator_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E1F3 RID: 123379 RVA: 0x002A9C5C File Offset: 0x002A7E5C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkArrayIterator.vtkArrayIterator_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601E1F4 RID: 123380
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayIterator_Initialize_04(HandleRef pThis, HandleRef array);

		/// <summary>
		/// Set the array this iterator will iterate over.
		/// After Initialize() has been called, the iterator is valid
		/// so long as the Array has not been modified
		/// (except using the iterator itself).
		/// If the array is modified, the iterator must be re-initialized.
		/// </summary>
		// Token: 0x0601E1F5 RID: 123381 RVA: 0x002A9C78 File Offset: 0x002A7E78
		public virtual void Initialize(vtkAbstractArray array)
		{
			vtkArrayIterator.vtkArrayIterator_Initialize_04(base.GetCppThis(), (array == null) ? default(HandleRef) : array.GetCppThis());
		}

		// Token: 0x0601E1F6 RID: 123382
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayIterator_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E1F7 RID: 123383 RVA: 0x002A9CA8 File Offset: 0x002A7EA8
		public override int IsA(string type)
		{
			return vtkArrayIterator.vtkArrayIterator_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601E1F8 RID: 123384
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayIterator_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E1F9 RID: 123385 RVA: 0x002A9CC8 File Offset: 0x002A7EC8
		public new static int IsTypeOf(string type)
		{
			return vtkArrayIterator.vtkArrayIterator_IsTypeOf_06(type);
		}

		// Token: 0x0601E1FA RID: 123386
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayIterator_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E1FB RID: 123387 RVA: 0x002A9CE4 File Offset: 0x002A7EE4
		public new vtkArrayIterator NewInstance()
		{
			vtkArrayIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayIterator.vtkArrayIterator_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E1FC RID: 123388
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayIterator_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E1FD RID: 123389 RVA: 0x002A9D40 File Offset: 0x002A7F40
		public new static vtkArrayIterator SafeDownCast(vtkObjectBase o)
		{
			vtkArrayIterator vtkArrayIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayIterator.vtkArrayIterator_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArrayIterator = (vtkArrayIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArrayIterator.Register(null);
				}
			}
			return vtkArrayIterator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FD0 RID: 8144
		public new const string MRFullTypeName = "Kitware.VTK.vtkArrayIterator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FD1 RID: 8145
		public new static readonly string MRClassNameKey = "class vtkArrayIterator";
	}
}
