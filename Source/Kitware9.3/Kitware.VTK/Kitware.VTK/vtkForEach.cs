using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkForEach
	/// </summary>
	/// <remarks>
	///  Algorithm allowing to implement a for loop using the VTK pipeline and a sister filter
	/// vtkEndFor
	///
	/// This filter begins a for loop that can execute a portion of a pipeline (sub-pipeline) a certain
	/// number of times. To be used in conjunction with the `vtkEndFor` filter that should end the loop.
	///
	/// &gt; Largely inspired by the ttkForEach/ttkEndFor in the TTK project
	/// &gt; (https://github.com/topology-tool-kit/ttk/tree/dev)
	///
	/// </remarks>
	/// <seealso>
	///  vtkEndFor, vtkExecutionRange
	/// </seealso>
	// Token: 0x020009D3 RID: 2515
	public class vtkForEach : vtkDataObjectAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A388 RID: 107400 RVA: 0x00245934 File Offset: 0x00243B34
		static vtkForEach()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkForEach.MRClassNameKey, Type.GetType("Kitware.VTK.vtkForEach"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A389 RID: 107401 RVA: 0x0024595C File Offset: 0x00243B5C
		public vtkForEach(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A38A RID: 107402
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkForEach_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A38B RID: 107403 RVA: 0x0024596C File Offset: 0x00243B6C
		public new static vtkForEach New()
		{
			vtkForEach result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkForEach.vtkForEach_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkForEach)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A38C RID: 107404 RVA: 0x002459C0 File Offset: 0x00243BC0
		public vtkForEach() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkForEach.vtkForEach_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A38D RID: 107405 RVA: 0x00245A04 File Offset: 0x00243C04
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A38E RID: 107406
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkForEach_FOR_EACH_FILTER_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Information key used to pass this filter into the pipeline
		/// </summary>
		// Token: 0x0601A38F RID: 107407 RVA: 0x00245A10 File Offset: 0x00243C10
		public static vtkInformationObjectBaseKey FOR_EACH_FILTER()
		{
			vtkInformationObjectBaseKey vtkInformationObjectBaseKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkForEach.vtkForEach_FOR_EACH_FILTER_01(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationObjectBaseKey = (vtkInformationObjectBaseKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationObjectBaseKey.Register(null);
				}
			}
			return vtkInformationObjectBaseKey;
		}

		// Token: 0x0601A390 RID: 107408
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkForEach_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A391 RID: 107409 RVA: 0x00245A7C File Offset: 0x00243C7C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkForEach.vtkForEach_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601A392 RID: 107410
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkForEach_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A393 RID: 107411 RVA: 0x00245A9C File Offset: 0x00243C9C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkForEach.vtkForEach_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601A394 RID: 107412
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkForEach_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A395 RID: 107413 RVA: 0x00245AB8 File Offset: 0x00243CB8
		public override int IsA(string type)
		{
			return vtkForEach.vtkForEach_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601A396 RID: 107414
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkForEach_IsIterating_05(HandleRef pThis);

		/// <summary>
		/// Method indicating whether the filter is currently iterating
		/// </summary>
		// Token: 0x0601A397 RID: 107415 RVA: 0x00245AD8 File Offset: 0x00243CD8
		public virtual bool IsIterating()
		{
			return vtkForEach.vtkForEach_IsIterating_05(base.GetCppThis()) != 0;
		}

		// Token: 0x0601A398 RID: 107416
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkForEach_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A399 RID: 107417 RVA: 0x00245B00 File Offset: 0x00243D00
		public new static int IsTypeOf(string type)
		{
			return vtkForEach.vtkForEach_IsTypeOf_06(type);
		}

		// Token: 0x0601A39A RID: 107418
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkForEach_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A39B RID: 107419 RVA: 0x00245B1C File Offset: 0x00243D1C
		public new vtkForEach NewInstance()
		{
			vtkForEach result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkForEach.vtkForEach_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkForEach)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A39C RID: 107420
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkForEach_RegisterEndFor_09(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Method for registering the end of the loop vtkEndFor filter
		/// </summary>
		// Token: 0x0601A39D RID: 107421 RVA: 0x00245B78 File Offset: 0x00243D78
		public virtual void RegisterEndFor(vtkEndFor arg0)
		{
			vtkForEach.vtkForEach_RegisterEndFor_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601A39E RID: 107422
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkForEach_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A39F RID: 107423 RVA: 0x00245BA8 File Offset: 0x00243DA8
		public new static vtkForEach SafeDownCast(vtkObjectBase o)
		{
			vtkForEach vtkForEach = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkForEach.vtkForEach_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkForEach = (vtkForEach)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkForEach.Register(null);
				}
			}
			return vtkForEach;
		}

		// Token: 0x0601A3A0 RID: 107424
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkForEach_SetRange_11(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Range object to use to control execution loop
		/// </summary>
		// Token: 0x0601A3A1 RID: 107425 RVA: 0x00245C28 File Offset: 0x00243E28
		public virtual void SetRange(vtkExecutionRange arg0)
		{
			vtkForEach.vtkForEach_SetRange_11(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C76 RID: 7286
		public new const string MRFullTypeName = "Kitware.VTK.vtkForEach";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C77 RID: 7287
		public new static readonly string MRClassNameKey = "class vtkForEach";
	}
}
