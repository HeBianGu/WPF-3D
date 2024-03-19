using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGenericPointIterator
	/// </summary>
	/// <remarks>
	///    iterator used to traverse points
	///
	/// This class (and subclasses) are used to iterate over points. Use it
	/// only in conjunction with vtkGenericDataSet (i.e., the adaptor framework).
	///
	/// Typical use is:
	/// &lt;pre&gt;
	/// vtkGenericDataSet *dataset;
	/// vtkGenericPointIterator *it = dataset-&gt;NewPointIterator();
	/// for (it-&gt;Begin(); !it-&gt;IsAtEnd(); it-&gt;Next());
	///   {
	///   x=it-&gt;GetPosition();
	///   }
	/// &lt;/pre&gt;
	/// </remarks>
	// Token: 0x02000A52 RID: 2642
	public abstract class vtkGenericPointIterator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B995 RID: 113045 RVA: 0x0026A067 File Offset: 0x00268267
		static vtkGenericPointIterator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericPointIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericPointIterator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B996 RID: 113046 RVA: 0x0026A08F File Offset: 0x0026828F
		public vtkGenericPointIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B997 RID: 113047 RVA: 0x0026A09D File Offset: 0x0026829D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B998 RID: 113048
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericPointIterator_Begin_01(HandleRef pThis);

		/// <summary>
		/// Move iterator to first position if any (loop initialization).
		/// </summary>
		// Token: 0x0601B999 RID: 113049 RVA: 0x0026A0A8 File Offset: 0x002682A8
		public virtual void Begin()
		{
			vtkGenericPointIterator.vtkGenericPointIterator_Begin_01(base.GetCppThis());
		}

		// Token: 0x0601B99A RID: 113050
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericPointIterator_GetId_02(HandleRef pThis);

		/// <summary>
		/// Return the unique identifier for the point, could be non-contiguous.
		/// \pre not_off: !IsAtEnd()
		/// </summary>
		// Token: 0x0601B99B RID: 113051 RVA: 0x0026A0B8 File Offset: 0x002682B8
		public virtual long GetId()
		{
			return vtkGenericPointIterator.vtkGenericPointIterator_GetId_02(base.GetCppThis());
		}

		// Token: 0x0601B99C RID: 113052
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericPointIterator_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK construction and type macros.
		/// </summary>
		// Token: 0x0601B99D RID: 113053 RVA: 0x0026A0D8 File Offset: 0x002682D8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGenericPointIterator.vtkGenericPointIterator_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601B99E RID: 113054
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericPointIterator_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK construction and type macros.
		/// </summary>
		// Token: 0x0601B99F RID: 113055 RVA: 0x0026A0F8 File Offset: 0x002682F8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGenericPointIterator.vtkGenericPointIterator_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601B9A0 RID: 113056
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericPointIterator_GetPosition_05(HandleRef pThis);

		/// <summary>
		/// Get the coordinates of the point at the current iterator position.
		/// \pre not_off: !IsAtEnd()
		/// \post result_exists: result!=0
		/// </summary>
		// Token: 0x0601B9A1 RID: 113057 RVA: 0x0026A114 File Offset: 0x00268314
		public virtual IntPtr GetPosition()
		{
			return vtkGenericPointIterator.vtkGenericPointIterator_GetPosition_05(base.GetCppThis());
		}

		// Token: 0x0601B9A2 RID: 113058
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericPointIterator_GetPosition_06(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Get the coordinates of the point at the current iterator position.
		/// \pre not_off: !IsAtEnd()
		/// \pre x_exists: x!=0
		/// </summary>
		// Token: 0x0601B9A3 RID: 113059 RVA: 0x0026A133 File Offset: 0x00268333
		public virtual void GetPosition(IntPtr x)
		{
			vtkGenericPointIterator.vtkGenericPointIterator_GetPosition_06(base.GetCppThis(), x);
		}

		// Token: 0x0601B9A4 RID: 113060
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericPointIterator_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK construction and type macros.
		/// </summary>
		// Token: 0x0601B9A5 RID: 113061 RVA: 0x0026A144 File Offset: 0x00268344
		public override int IsA(string type)
		{
			return vtkGenericPointIterator.vtkGenericPointIterator_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601B9A6 RID: 113062
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericPointIterator_IsAtEnd_08(HandleRef pThis);

		/// <summary>
		/// Is the iterator at the end of traversal?
		/// </summary>
		// Token: 0x0601B9A7 RID: 113063 RVA: 0x0026A164 File Offset: 0x00268364
		public virtual int IsAtEnd()
		{
			return vtkGenericPointIterator.vtkGenericPointIterator_IsAtEnd_08(base.GetCppThis());
		}

		// Token: 0x0601B9A8 RID: 113064
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericPointIterator_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK construction and type macros.
		/// </summary>
		// Token: 0x0601B9A9 RID: 113065 RVA: 0x0026A184 File Offset: 0x00268384
		public new static int IsTypeOf(string type)
		{
			return vtkGenericPointIterator.vtkGenericPointIterator_IsTypeOf_09(type);
		}

		// Token: 0x0601B9AA RID: 113066
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericPointIterator_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK construction and type macros.
		/// </summary>
		// Token: 0x0601B9AB RID: 113067 RVA: 0x0026A1A0 File Offset: 0x002683A0
		public new vtkGenericPointIterator NewInstance()
		{
			vtkGenericPointIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericPointIterator.vtkGenericPointIterator_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericPointIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B9AC RID: 113068
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericPointIterator_Next_11(HandleRef pThis);

		/// <summary>
		/// Move the iterator to the next position in the list.
		/// \pre not_off: !IsAtEnd()
		/// </summary>
		// Token: 0x0601B9AD RID: 113069 RVA: 0x0026A1FA File Offset: 0x002683FA
		public virtual void Next()
		{
			vtkGenericPointIterator.vtkGenericPointIterator_Next_11(base.GetCppThis());
		}

		// Token: 0x0601B9AE RID: 113070
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericPointIterator_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK construction and type macros.
		/// </summary>
		// Token: 0x0601B9AF RID: 113071 RVA: 0x0026A20C File Offset: 0x0026840C
		public new static vtkGenericPointIterator SafeDownCast(vtkObjectBase o)
		{
			vtkGenericPointIterator vtkGenericPointIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericPointIterator.vtkGenericPointIterator_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericPointIterator = (vtkGenericPointIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericPointIterator.Register(null);
				}
			}
			return vtkGenericPointIterator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D98 RID: 7576
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericPointIterator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D99 RID: 7577
		public new static readonly string MRClassNameKey = "class vtkGenericPointIterator";
	}
}
