using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkPassSelectedArrays
	/// </summary>
	/// <remarks>
	///  pass through chosen arrays
	///
	/// vtkPassSelectedArrays can be used to pass through chosen arrays. It is
	/// intended as a replacement for vtkPassArrays filter with a more standard API
	/// that uses `vtkDataArraySelection` to choose arrays to pass through.
	///
	/// To enable/disable arrays to pass, get the appropriate `vtkDataArraySelection`
	/// instance using `GetArraySelection` or the association specific get methods
	/// such as `GetPointDataArraySelection`, `GetCellDataArraySelection` etc. and
	/// then enable/disable arrays using `vtkDataArraySelection` API. Using
	/// vtkDataArraySelection::SetUnknownArraySetting` one also dictate how arrays
	/// not explicitly listed are to be handled.
	///
	/// </remarks>
	// Token: 0x020008C8 RID: 2248
	public class vtkPassSelectedArrays : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060173DC RID: 95196 RVA: 0x00209FD9 File Offset: 0x002081D9
		static vtkPassSelectedArrays()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPassSelectedArrays.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPassSelectedArrays"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060173DD RID: 95197 RVA: 0x0020A001 File Offset: 0x00208201
		public vtkPassSelectedArrays(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060173DE RID: 95198
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassSelectedArrays_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060173DF RID: 95199 RVA: 0x0020A010 File Offset: 0x00208210
		public new static vtkPassSelectedArrays New()
		{
			vtkPassSelectedArrays result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassSelectedArrays.vtkPassSelectedArrays_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPassSelectedArrays)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060173E0 RID: 95200 RVA: 0x0020A064 File Offset: 0x00208264
		public vtkPassSelectedArrays() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPassSelectedArrays.vtkPassSelectedArrays_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060173E1 RID: 95201 RVA: 0x0020A0A8 File Offset: 0x002082A8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060173E2 RID: 95202
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassSelectedArrays_EnabledOff_01(HandleRef pThis);

		/// <summary>
		/// Enable/disable this filter. When disabled, this filter passes all input arrays
		/// irrespective of the array selections. Default is `true`.
		/// </summary>
		// Token: 0x060173E3 RID: 95203 RVA: 0x0020A0B3 File Offset: 0x002082B3
		public virtual void EnabledOff()
		{
			vtkPassSelectedArrays.vtkPassSelectedArrays_EnabledOff_01(base.GetCppThis());
		}

		// Token: 0x060173E4 RID: 95204
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassSelectedArrays_EnabledOn_02(HandleRef pThis);

		/// <summary>
		/// Enable/disable this filter. When disabled, this filter passes all input arrays
		/// irrespective of the array selections. Default is `true`.
		/// </summary>
		// Token: 0x060173E5 RID: 95205 RVA: 0x0020A0C2 File Offset: 0x002082C2
		public virtual void EnabledOn()
		{
			vtkPassSelectedArrays.vtkPassSelectedArrays_EnabledOn_02(base.GetCppThis());
		}

		// Token: 0x060173E6 RID: 95206
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassSelectedArrays_GetArraySelection_03(HandleRef pThis, int association, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the vtkDataArraySelection instance associated with a particular
		/// array association type (vtkDataObject::FieldAssociations). Returns nullptr
		/// if the association type is invalid others the corresponding
		/// vtkDataArraySelection instance is returned.
		/// </summary>
		// Token: 0x060173E7 RID: 95207 RVA: 0x0020A0D4 File Offset: 0x002082D4
		public vtkDataArraySelection GetArraySelection(int association)
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassSelectedArrays.vtkPassSelectedArrays_GetArraySelection_03(base.GetCppThis(), association, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x060173E8 RID: 95208
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassSelectedArrays_GetCellDataArraySelection_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Convenience methods that call `GetArraySelection` with corresponding
		/// association type.
		/// </summary>
		// Token: 0x060173E9 RID: 95209 RVA: 0x0020A144 File Offset: 0x00208344
		public vtkDataArraySelection GetCellDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassSelectedArrays.vtkPassSelectedArrays_GetCellDataArraySelection_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x060173EA RID: 95210
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassSelectedArrays_GetEdgeDataArraySelection_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Convenience methods that call `GetArraySelection` with corresponding
		/// association type.
		/// </summary>
		// Token: 0x060173EB RID: 95211 RVA: 0x0020A1B4 File Offset: 0x002083B4
		public vtkDataArraySelection GetEdgeDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassSelectedArrays.vtkPassSelectedArrays_GetEdgeDataArraySelection_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x060173EC RID: 95212
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPassSelectedArrays_GetEnabled_06(HandleRef pThis);

		/// <summary>
		/// Enable/disable this filter. When disabled, this filter passes all input arrays
		/// irrespective of the array selections. Default is `true`.
		/// </summary>
		// Token: 0x060173ED RID: 95213 RVA: 0x0020A224 File Offset: 0x00208424
		public virtual bool GetEnabled()
		{
			return vtkPassSelectedArrays.vtkPassSelectedArrays_GetEnabled_06(base.GetCppThis()) != 0;
		}

		// Token: 0x060173EE RID: 95214
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassSelectedArrays_GetFieldDataArraySelection_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Convenience methods that call `GetArraySelection` with corresponding
		/// association type.
		/// </summary>
		// Token: 0x060173EF RID: 95215 RVA: 0x0020A24C File Offset: 0x0020844C
		public vtkDataArraySelection GetFieldDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassSelectedArrays.vtkPassSelectedArrays_GetFieldDataArraySelection_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x060173F0 RID: 95216
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPassSelectedArrays_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060173F1 RID: 95217 RVA: 0x0020A2BC File Offset: 0x002084BC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPassSelectedArrays.vtkPassSelectedArrays_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x060173F2 RID: 95218
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPassSelectedArrays_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060173F3 RID: 95219 RVA: 0x0020A2DC File Offset: 0x002084DC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPassSelectedArrays.vtkPassSelectedArrays_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x060173F4 RID: 95220
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassSelectedArrays_GetPointDataArraySelection_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Convenience methods that call `GetArraySelection` with corresponding
		/// association type.
		/// </summary>
		// Token: 0x060173F5 RID: 95221 RVA: 0x0020A2F8 File Offset: 0x002084F8
		public vtkDataArraySelection GetPointDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassSelectedArrays.vtkPassSelectedArrays_GetPointDataArraySelection_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x060173F6 RID: 95222
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassSelectedArrays_GetRowDataArraySelection_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Convenience methods that call `GetArraySelection` with corresponding
		/// association type.
		/// </summary>
		// Token: 0x060173F7 RID: 95223 RVA: 0x0020A368 File Offset: 0x00208568
		public vtkDataArraySelection GetRowDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassSelectedArrays.vtkPassSelectedArrays_GetRowDataArraySelection_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x060173F8 RID: 95224
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassSelectedArrays_GetVertexDataArraySelection_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Convenience methods that call `GetArraySelection` with corresponding
		/// association type.
		/// </summary>
		// Token: 0x060173F9 RID: 95225 RVA: 0x0020A3D8 File Offset: 0x002085D8
		public vtkDataArraySelection GetVertexDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassSelectedArrays.vtkPassSelectedArrays_GetVertexDataArraySelection_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x060173FA RID: 95226
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPassSelectedArrays_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060173FB RID: 95227 RVA: 0x0020A448 File Offset: 0x00208648
		public override int IsA(string type)
		{
			return vtkPassSelectedArrays.vtkPassSelectedArrays_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x060173FC RID: 95228
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPassSelectedArrays_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060173FD RID: 95229 RVA: 0x0020A468 File Offset: 0x00208668
		public new static int IsTypeOf(string type)
		{
			return vtkPassSelectedArrays.vtkPassSelectedArrays_IsTypeOf_14(type);
		}

		// Token: 0x060173FE RID: 95230
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassSelectedArrays_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060173FF RID: 95231 RVA: 0x0020A484 File Offset: 0x00208684
		public new vtkPassSelectedArrays NewInstance()
		{
			vtkPassSelectedArrays result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassSelectedArrays.vtkPassSelectedArrays_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPassSelectedArrays)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017400 RID: 95232
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassSelectedArrays_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017401 RID: 95233 RVA: 0x0020A4E0 File Offset: 0x002086E0
		public new static vtkPassSelectedArrays SafeDownCast(vtkObjectBase o)
		{
			vtkPassSelectedArrays vtkPassSelectedArrays = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassSelectedArrays.vtkPassSelectedArrays_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPassSelectedArrays = (vtkPassSelectedArrays)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPassSelectedArrays.Register(null);
				}
			}
			return vtkPassSelectedArrays;
		}

		// Token: 0x06017402 RID: 95234
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassSelectedArrays_SetEnabled_18(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable/disable this filter. When disabled, this filter passes all input arrays
		/// irrespective of the array selections. Default is `true`.
		/// </summary>
		// Token: 0x06017403 RID: 95235 RVA: 0x0020A55F File Offset: 0x0020875F
		public virtual void SetEnabled(bool _arg)
		{
			vtkPassSelectedArrays.vtkPassSelectedArrays_SetEnabled_18(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A03 RID: 6659
		public new const string MRFullTypeName = "Kitware.VTK.vtkPassSelectedArrays";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A04 RID: 6660
		public new static readonly string MRClassNameKey = "class vtkPassSelectedArrays";
	}
}
