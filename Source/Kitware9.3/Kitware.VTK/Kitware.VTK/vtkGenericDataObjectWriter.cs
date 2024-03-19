using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGenericDataObjectWriter
	/// </summary>
	/// <remarks>
	///    writes any type of vtk data object to file
	///
	/// vtkGenericDataObjectWriter is a concrete class that writes data objects
	/// to disk. The input to this object is any subclass of vtkDataObject.
	/// </remarks>
	// Token: 0x02000709 RID: 1801
	public class vtkGenericDataObjectWriter : vtkDataWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012EEE RID: 77550 RVA: 0x001AAFC7 File Offset: 0x001A91C7
		static vtkGenericDataObjectWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericDataObjectWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericDataObjectWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012EEF RID: 77551 RVA: 0x001AAFEF File Offset: 0x001A91EF
		public vtkGenericDataObjectWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012EF0 RID: 77552
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericDataObjectWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012EF1 RID: 77553 RVA: 0x001AB000 File Offset: 0x001A9200
		public new static vtkGenericDataObjectWriter New()
		{
			vtkGenericDataObjectWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericDataObjectWriter.vtkGenericDataObjectWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericDataObjectWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012EF2 RID: 77554 RVA: 0x001AB054 File Offset: 0x001A9254
		public vtkGenericDataObjectWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGenericDataObjectWriter.vtkGenericDataObjectWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012EF3 RID: 77555 RVA: 0x001AB098 File Offset: 0x001A9298
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012EF4 RID: 77556
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericDataObjectWriter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012EF5 RID: 77557 RVA: 0x001AB0A4 File Offset: 0x001A92A4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGenericDataObjectWriter.vtkGenericDataObjectWriter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06012EF6 RID: 77558
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericDataObjectWriter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012EF7 RID: 77559 RVA: 0x001AB0C4 File Offset: 0x001A92C4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGenericDataObjectWriter.vtkGenericDataObjectWriter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06012EF8 RID: 77560
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericDataObjectWriter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012EF9 RID: 77561 RVA: 0x001AB0E0 File Offset: 0x001A92E0
		public override int IsA(string type)
		{
			return vtkGenericDataObjectWriter.vtkGenericDataObjectWriter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06012EFA RID: 77562
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericDataObjectWriter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012EFB RID: 77563 RVA: 0x001AB100 File Offset: 0x001A9300
		public new static int IsTypeOf(string type)
		{
			return vtkGenericDataObjectWriter.vtkGenericDataObjectWriter_IsTypeOf_04(type);
		}

		// Token: 0x06012EFC RID: 77564
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericDataObjectWriter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012EFD RID: 77565 RVA: 0x001AB11C File Offset: 0x001A931C
		public new vtkGenericDataObjectWriter NewInstance()
		{
			vtkGenericDataObjectWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericDataObjectWriter.vtkGenericDataObjectWriter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericDataObjectWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012EFE RID: 77566
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericDataObjectWriter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012EFF RID: 77567 RVA: 0x001AB178 File Offset: 0x001A9378
		public new static vtkGenericDataObjectWriter SafeDownCast(vtkObjectBase o)
		{
			vtkGenericDataObjectWriter vtkGenericDataObjectWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericDataObjectWriter.vtkGenericDataObjectWriter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericDataObjectWriter = (vtkGenericDataObjectWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericDataObjectWriter.Register(null);
				}
			}
			return vtkGenericDataObjectWriter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015DE RID: 5598
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericDataObjectWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015DF RID: 5599
		public new static readonly string MRClassNameKey = "class vtkGenericDataObjectWriter";
	}
}
